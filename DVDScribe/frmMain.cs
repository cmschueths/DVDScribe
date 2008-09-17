﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace DVDScribe
{
    public partial class frmMain : Form
    {
        private enum Mode { [Description("Drag mode selected")] mDrag,[Description("Text adding mode selected")] mText, [Description("Image adding mode selected")] mImage }

        private Bitmap Cover = new Bitmap(640, 640);
        private Bitmap BufferImage = null;
        private Double ZoomV = 1.0;
        private Double ZoomH = 1.0;
        private int StartX = 4;
        private int StartY = 4;
        private int DeltaX = 0;
        private int DeltaY = 0;
        private float pAngle;        

        private float Angle
        {
            get
            {
                return pAngle;
            }
            set
            {
                pAngle = value;
                rotateImage(Cover, pAngle);
                pbxCanvas.Invalidate();
            }
        }

        private Mode pMode;
        private Mode CurrentMode
        {
            get
            {
                return pMode;
            }
            set
            {
                pMode = value;
                tsbtnDragMode.Checked = false;
                tsbtnImageMode.Checked = false;
                tsbtnTextMode.Checked = false;
                switch (value)
                {
                    case Mode.mDrag:
                        tsbtnDragMode.Checked = true;
                        lbMode.Text = Utils.getEnumText(Mode.mDrag);
                        break;
                    case Mode.mImage:
                        tsbtnImageMode.Checked = true;
                        lbMode.Text = Utils.getEnumText(Mode.mImage);
                        break;
                    case Mode.mText:
                        tsbtnTextMode.Checked = true;
                        lbMode.Text = Utils.getEnumText(Mode.mText);
                        break;
                }
            }
        }
        private List<libControls.dsControl> dsControls;

        private byte brushTransparency = 127;
        private bool DragStart = false;      
 
        public frmMain()
        {
            InitializeComponent();
            dsControls = new List<libControls.dsControl>();
            CurrentMode = Mode.mDrag;
        }

        private void OnControlChanged()
        {
            pbxCanvas.Invalidate();
        }
        
        private void rotateImage(Bitmap b, float angle)
        {
            if (b != null)
            {
                if (BufferImage == null)
                {
                    BufferImage = new Bitmap((int)(b.Width), (int)(b.Height));
                }
                Graphics g = Graphics.FromImage(BufferImage);
                g.TranslateTransform(((float)b.Width / 2) + StartX, ((float)b.Height / 2) + StartY);
                g.RotateTransform(angle);
                g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
                Rectangle rect = new Rectangle(0, 0, (int)b.Width, (int)b.Height);
                g.DrawImage(b, rect);
            }            
        }


        private void pbxCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Bitmap bmp = (BufferImage == null) ? Cover : BufferImage;

            Rectangle rect = new Rectangle(StartX, StartY, (int)(Cover.Width * ZoomH), (int)(Cover.Height * ZoomV));
            g.DrawImage(bmp, rect);
            
            SolidBrush transBrush = new SolidBrush(Color.FromArgb(brushTransparency, 150, 150, 150));            
            Pen pn = new Pen(Color.FromArgb(128, 100, 100, 100));
            Pen thickPen = new Pen(transBrush,200);
            g.DrawEllipse(thickPen, -100, -100, 840, 840);
            g.DrawEllipse(pn, 0, 0, 640, 640);           
            g.DrawEllipse(pn, 192, 192, 256, 256);
            g.FillEllipse(transBrush, 192, 192, 256, 256);

            foreach (libControls.dsControl aControl in dsControls)
            {
                aControl.Paint(g);
            }                      
        }

        private void resetToBlank()
        {
            if (MessageBox.Show("Are you sure you want to clear the current image?","New image", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Cover = new Bitmap(640, 640);
                BufferImage = null;
                cleardsControls();
                pbxCanvas.Invalidate();
            }
        }

        private void SelectBackground()
        {
            frmSelectBackground f = new frmSelectBackground();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Cover = (Bitmap)Bitmap.FromFile(f.SelectedFile, false);
                
                ZoomH = 640.00 / Cover.Width;
                ZoomV = 640.00 / Cover.Height;
                if ((int)(ZoomH * 1000) > tbZoom.Maximum)
                {
                    tbZoom.Maximum = (int)(ZoomH * 1000);
                }
                if ((int)(ZoomV * 1000) > tbZoomV.Maximum)
                {
                    tbZoomV.Maximum = (int)(ZoomV * 1000);
                }
                tbZoom.Value = (int)(ZoomH * 1000);
                tbZoomV.Value = (int)(ZoomV * 1000);                
            }
            else
            {
                Cover = new Bitmap(640, 640);
            }
            pbxCanvas.Invalidate();
        }

        private void acnNewCover(object sender, EventArgs e)
        {
            SelectBackground();
        }

        private void tbZoom_ValueChanged(object sender, EventArgs e)
        {
            ZoomH = (tbZoom.Value * 0.001);
            if (cbxKeepRatio.Checked)
            {
                tbZoomV.Value = tbZoom.Value;
            }
            pbxCanvas.Invalidate();
        }

        private void pbxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (libControls.dsControl aControl in dsControls)
            {
                if (aControl.isPickedUp)
                {
                    aControl.Drag(e.X, e.Y);
                    pbxCanvas.Invalidate();
                    return;
                }
            }

            if (DragStart)
            {
                if (DeltaX < e.X)
                {
                    StartX = StartX + (e.X - DeltaX);
                }
                else if (DeltaX > e.X)
                {
                    StartX = StartX + (e.X - DeltaX);
                }
                if (DeltaY < e.Y)
                {
                    StartY = StartY + (e.Y - DeltaY);
                }
                else if (DeltaY > e.Y)
                {
                    StartY = StartY + (e.Y - DeltaY);
                }                
                pbxCanvas.Invalidate();                
            }
            DeltaX = e.X;
            DeltaY = e.Y;
        }

        private void pbxCanvas_MouseDown(object sender, MouseEventArgs e)
        {         
            Cursor = Cursors.NoMove2D;
            DragStart = true;

            foreach (libControls.dsControl aControl in dsControls)
            {
                if (aControl.editorVisible)
                {
                    aControl.CloseEditor(pbxCanvas);
                }
                if (aControl.isOver(e.X,e.Y))
                {
                    aControl.PickUp(e.X, e.Y);                    
                    return;
                }
            }

            if (DeltaX < e.X)
            {
                DeltaX = DeltaX + (e.X - DeltaX);
            }
            else if (DeltaX > e.X)
            {
                DeltaX = DeltaX + (e.X - DeltaX);
            }

            if (DeltaY < e.Y)
            {
                DeltaY = DeltaY + (e.Y - DeltaY);
            }
            else if (DeltaY > e.Y)
            {
                DeltaY = DeltaY + (e.Y - DeltaY);
            }
        }

        private void pbxCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (libControls.dsControl aControl in dsControls)
            {
                if (aControl.isPickedUp)
                {
                    aControl.PutDown();                    
                }
            }

            DragStart = false;
            Cursor = Cursors.Default;
            DeltaX = e.X;
            DeltaY = e.Y;
        }

        private string genLightScribeFile()
        {
            Bitmap b = new Bitmap(640,640);
            b.MakeTransparent(Color.White);
           
            Graphics g = Graphics.FromImage(b);
            
            g.DrawImage(Cover, new Rectangle(StartX, StartY, (int)(Cover.Width * ZoomH), (int)(Cover.Height * ZoomV)));
            foreach (libControls.dsControl aControl in dsControls)
            {
                aControl.AddToImage(g);
            }
            string AFileName = Path.GetTempFileName() + ".bmp";            

            b.Save(AFileName, System.Drawing.Imaging.ImageFormat.Bmp);
            return AFileName;            
        }

        private void acnResetCover(object sender, EventArgs e)
        {
            resetToBlank();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            try
            {
                libLS.LightScribeSoftwareInstalled();
                if (!libLS.HasLightScribeDrive())
                {
                    tsDriveState.Text = "No LightScribe drive found";
                    tsDriveState.Visible = true;
                }
            }
            catch (libLS.DllNotFound ex)
            {
                MessageBox.Show(ex.Message);
                tsSoftwareState.Text = "LightScribe software not found";
                tsSoftwareState.Visible = true;
            }
        }

        private void acnPreview(object sender, EventArgs e)
        {
            libLS.DoPrintPreview(genLightScribeFile());
        }

        private void acnDoGrayScale(object sender, EventArgs e)
        {
            libImage.GrayScale(Cover);
            pbxCanvas.Invalidate();
        }

        private void acnDoCiontrastChange(object sender, EventArgs e)
        {
            using (frmSelectContrast f = new frmSelectContrast()){
                if (f.ShowDialog() == DialogResult.OK){
                    if (libImage.SetContrast(Cover, (sbyte)f.edtValue.Value))
                    {
                        pbxCanvas.Invalidate();
                    }
                }
            }            
        }

        private void tbZoomH_ValueChanged(object sender, EventArgs e)
        {
            ZoomV = (tbZoomV.Value * 0.001);            
            if (cbxKeepRatio.Checked)
            {
                tbZoom.Value = tbZoomV.Value;
            }
            pbxCanvas.Invalidate();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tbZoom.Value = 1536;
            tbZoomV.Value = 1590;                        
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetToBlank();
        }

        private void pbxCanvas_DoubleClick(object sender, EventArgs e)
        {
            foreach (libControls.dsControl aControl in dsControls)
            {
                if (aControl.isOver(DeltaX, DeltaY))
                {
                    aControl.LauchEditor(pbxCanvas); 
                }
            }            
        }

        private void tsbtnTextMode_Click(object sender, EventArgs e)
        {
            CurrentMode = Mode.mText;
        }

        private void tsbtnDragMode_Click(object sender, EventArgs e)
        {
            CurrentMode = Mode.mDrag;
        }

        private void tsbtnImageMode_Click(object sender, EventArgs e)
        {
            CurrentMode = Mode.mImage;            
        }

        private void pbxCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            switch (CurrentMode)
            {
                case Mode.mText: libControls.TextField tf = new libControls.TextField(e.X,e.Y,0,0);
                    dsControls.Add(tf);
                    tf.OnChanged = OnControlChanged;
                    tf.LauchEditor(pbxCanvas);                    
                    CurrentMode = Mode.mDrag;
                    break;
                case Mode.mImage: libControls.ImageField imf = new libControls.ImageField("",e.X,e.Y,0,0);
                    dsControls.Add(imf);
                    imf.OnChanged = OnControlChanged;
                    imf.LauchEditor(pbxCanvas);
                    CurrentMode = Mode.mDrag;
                    break;
                case Mode.mDrag:
                    foreach(libControls.dsControl aControl in dsControls)
                    {
                        if (aControl.Selected)
                        {
                            aControl.Selected = false;
                        }
                        if (aControl.isOver(e.X,e.Y))
                        {
                            aControl.Selected = true;
                        }
                    }
                    break;
            }
        }

        private void deleteControls()
        {
            foreach (libControls.dsControl aControl in dsControls)
            {
                if (aControl.Selected)
                {
                    libControls.dsControl fControl = aControl;
                    dsControls.Remove(fControl);
                    fControl = null;
                    pbxCanvas.Invalidate();
                    break;
                }
            }
        }

        private void cleardsControls()
        {
            int aCount = 0;
            while (dsControls.Count > 0)
            {
                libControls.dsControl aControl = dsControls[aCount];
                dsControls.Remove(aControl);
                aControl = null;
            }
        }

        private void acnDeleteControl(object sender, EventArgs e)
        {
            deleteControls();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Angle = (float)numericUpDown1.Value;            
        }

        private void acnExitApplication(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close DVDScribe?", "Exit application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
