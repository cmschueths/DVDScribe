namespace DVDScribe
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.dVDScribeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsQMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnReset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnPrintPreview = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnEditOptions = new System.Windows.Forms.ToolStripDropDownButton();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDragMode = new System.Windows.Forms.ToolStripButton();
            this.btnTextMode = new System.Windows.Forms.ToolStripButton();
            this.btnImageMode = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.ssLightScribeState = new System.Windows.Forms.StatusStrip();
            this.tsSoftwareState = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsDriveState = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbZoom = new System.Windows.Forms.TrackBar();
            this.tbZoomV = new System.Windows.Forms.TrackBar();
            this.cbxKeepRatio = new System.Windows.Forms.CheckBox();
            this.pbxCanvas = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.msMainMenu.SuspendLayout();
            this.tsQMenu.SuspendLayout();
            this.ssLightScribeState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoomV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dVDScribeToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(683, 30);
            this.msMainMenu.TabIndex = 0;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // dVDScribeToolStripMenuItem
            // 
            this.dVDScribeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.printToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.dVDScribeToolStripMenuItem.Image = global::DVDScribe.Properties.Resources.drive_optical;
            this.dVDScribeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dVDScribeToolStripMenuItem.Name = "dVDScribeToolStripMenuItem";
            this.dVDScribeToolStripMenuItem.Size = new System.Drawing.Size(90, 26);
            this.dVDScribeToolStripMenuItem.Text = "DVDScribe";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::DVDScribe.Properties.Resources.gtk_new;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(104, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::DVDScribe.Properties.Resources.gtk_save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(104, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::DVDScribe.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectBackToolStripMenuItem,
            this.editBackgroundToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // selectBackToolStripMenuItem
            // 
            this.selectBackToolStripMenuItem.Name = "selectBackToolStripMenuItem";
            this.selectBackToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.selectBackToolStripMenuItem.Text = "Select image";
            // 
            // editBackgroundToolStripMenuItem
            // 
            this.editBackgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayscaleToolStripMenuItem1,
            this.contrastToolStripMenuItem1});
            this.editBackgroundToolStripMenuItem.Name = "editBackgroundToolStripMenuItem";
            this.editBackgroundToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.editBackgroundToolStripMenuItem.Text = "Image";
            // 
            // grayscaleToolStripMenuItem1
            // 
            this.grayscaleToolStripMenuItem1.Name = "grayscaleToolStripMenuItem1";
            this.grayscaleToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.grayscaleToolStripMenuItem1.Text = "Grayscale";
            // 
            // contrastToolStripMenuItem1
            // 
            this.contrastToolStripMenuItem1.Name = "contrastToolStripMenuItem1";
            this.contrastToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.contrastToolStripMenuItem1.Text = "Contrast";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tsQMenu
            // 
            this.tsQMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsQMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnOpenFile,
            this.toolStripButton1,
            this.tsbtnReset,
            this.toolStripSeparator2,
            this.tsbtnPrintPreview,
            this.toolStripSeparator1,
            this.tsbtnEditOptions,
            this.btnDragMode,
            this.btnTextMode,
            this.btnImageMode,
            this.btnDelete});
            this.tsQMenu.Location = new System.Drawing.Point(0, 30);
            this.tsQMenu.Name = "tsQMenu";
            this.tsQMenu.Size = new System.Drawing.Size(683, 31);
            this.tsQMenu.TabIndex = 1;
            this.tsQMenu.Text = "toolStrip1";
            // 
            // tsbtnOpenFile
            // 
            this.tsbtnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOpenFile.Name = "tsbtnOpenFile";
            this.tsbtnOpenFile.Size = new System.Drawing.Size(23, 28);
            this.tsbtnOpenFile.Text = "toolStripButton1";
            this.tsbtnOpenFile.ToolTipText = "Select background";
            this.tsbtnOpenFile.Click += new System.EventHandler(this.tsbtnOpenFile_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::DVDScribe.Properties.Resources.document_save_as;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // tsbtnReset
            // 
            this.tsbtnReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnReset.Image = global::DVDScribe.Properties.Resources.view_refresh;
            this.tsbtnReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnReset.Name = "tsbtnReset";
            this.tsbtnReset.Size = new System.Drawing.Size(28, 28);
            this.tsbtnReset.Text = "toolStripButton2";
            this.tsbtnReset.Click += new System.EventHandler(this.tsbtnReset_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbtnPrintPreview
            // 
            this.tsbtnPrintPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPrintPreview.Image = global::DVDScribe.Properties.Resources.document_print_preview;
            this.tsbtnPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPrintPreview.Name = "tsbtnPrintPreview";
            this.tsbtnPrintPreview.Size = new System.Drawing.Size(28, 28);
            this.tsbtnPrintPreview.Text = "toolStripButton3";
            this.tsbtnPrintPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsbtnPrintPreview.ToolTipText = "Print preview";
            this.tsbtnPrintPreview.Click += new System.EventHandler(this.tsbtnPrintPreview_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbtnEditOptions
            // 
            this.tsbtnEditOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEditOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayscaleToolStripMenuItem,
            this.contrastToolStripMenuItem});
            this.tsbtnEditOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditOptions.Name = "tsbtnEditOptions";
            this.tsbtnEditOptions.Size = new System.Drawing.Size(13, 28);
            this.tsbtnEditOptions.Text = "toolStripDropDownButton1";
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // contrastToolStripMenuItem
            // 
            this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            this.contrastToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.contrastToolStripMenuItem.Text = "Contrast";
            this.contrastToolStripMenuItem.Click += new System.EventHandler(this.contrastToolStripMenuItem_Click);
            // 
            // btnDragMode
            // 
            this.btnDragMode.CheckOnClick = true;
            this.btnDragMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDragMode.Image = global::DVDScribe.Properties.Resources.stock_fullscreen;
            this.btnDragMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDragMode.Name = "btnDragMode";
            this.btnDragMode.Size = new System.Drawing.Size(28, 28);
            this.btnDragMode.Text = "toolStripButton2";
            this.btnDragMode.Click += new System.EventHandler(this.btnDragMode_Click);
            // 
            // btnTextMode
            // 
            this.btnTextMode.CheckOnClick = true;
            this.btnTextMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTextMode.Image = global::DVDScribe.Properties.Resources.format_text_bold;
            this.btnTextMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTextMode.Name = "btnTextMode";
            this.btnTextMode.Size = new System.Drawing.Size(28, 28);
            this.btnTextMode.Text = "toolStripButton3";
            this.btnTextMode.Click += new System.EventHandler(this.btnTextMode_Click);
            // 
            // btnImageMode
            // 
            this.btnImageMode.CheckOnClick = true;
            this.btnImageMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImageMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImageMode.Name = "btnImageMode";
            this.btnImageMode.Size = new System.Drawing.Size(23, 28);
            this.btnImageMode.Text = "toolStripButton4";
            this.btnImageMode.Click += new System.EventHandler(this.btnImageMode_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = global::DVDScribe.Properties.Resources.gtk_delete;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(28, 28);
            this.btnDelete.Text = "toolStripButton2";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ssLightScribeState
            // 
            this.ssLightScribeState.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSoftwareState,
            this.tsDriveState,
            this.lbMode});
            this.ssLightScribeState.Location = new System.Drawing.Point(0, 752);
            this.ssLightScribeState.Name = "ssLightScribeState";
            this.ssLightScribeState.Size = new System.Drawing.Size(683, 22);
            this.ssLightScribeState.TabIndex = 2;
            // 
            // tsSoftwareState
            // 
            this.tsSoftwareState.Image = global::DVDScribe.Properties.Resources.dialog_cancel;
            this.tsSoftwareState.Name = "tsSoftwareState";
            this.tsSoftwareState.Size = new System.Drawing.Size(16, 17);
            this.tsSoftwareState.Visible = false;
            // 
            // tsDriveState
            // 
            this.tsDriveState.Image = global::DVDScribe.Properties.Resources.dialog_cancel;
            this.tsDriveState.Name = "tsDriveState";
            this.tsDriveState.Size = new System.Drawing.Size(16, 17);
            this.tsDriveState.Visible = false;
            // 
            // lbMode
            // 
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(59, 17);
            this.lbMode.Text = "Drag mode";
            // 
            // tbZoom
            // 
            this.tbZoom.AutoSize = false;
            this.tbZoom.Location = new System.Drawing.Point(12, 714);
            this.tbZoom.Maximum = 3000;
            this.tbZoom.Name = "tbZoom";
            this.tbZoom.Size = new System.Drawing.Size(644, 20);
            this.tbZoom.TabIndex = 4;
            this.tbZoom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbZoom.Value = 1000;
            this.tbZoom.ValueChanged += new System.EventHandler(this.tbZoom_ValueChanged);
            // 
            // tbZoomV
            // 
            this.tbZoomV.AutoSize = false;
            this.tbZoomV.Location = new System.Drawing.Point(662, 64);
            this.tbZoomV.Maximum = 3000;
            this.tbZoomV.Name = "tbZoomV";
            this.tbZoomV.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbZoomV.RightToLeftLayout = true;
            this.tbZoomV.Size = new System.Drawing.Size(20, 644);
            this.tbZoomV.TabIndex = 6;
            this.tbZoomV.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbZoomV.Value = 1000;
            this.tbZoomV.ValueChanged += new System.EventHandler(this.tbZoomH_ValueChanged);
            // 
            // cbxKeepRatio
            // 
            this.cbxKeepRatio.AutoSize = true;
            this.cbxKeepRatio.Location = new System.Drawing.Point(12, 731);
            this.cbxKeepRatio.Name = "cbxKeepRatio";
            this.cbxKeepRatio.Size = new System.Drawing.Size(74, 17);
            this.cbxKeepRatio.TabIndex = 7;
            this.cbxKeepRatio.Text = "Keep ratio";
            this.cbxKeepRatio.UseVisualStyleBackColor = true;
            // 
            // pbxCanvas
            // 
            this.pbxCanvas.BackColor = System.Drawing.Color.White;
            this.pbxCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCanvas.Location = new System.Drawing.Point(12, 64);
            this.pbxCanvas.Name = "pbxCanvas";
            this.pbxCanvas.Size = new System.Drawing.Size(644, 644);
            this.pbxCanvas.TabIndex = 3;
            this.pbxCanvas.TabStop = false;
            this.pbxCanvas.DoubleClick += new System.EventHandler(this.pbxCanvas_DoubleClick);
            this.pbxCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxCanvas_MouseMove);
            this.pbxCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbxCanvas_MouseClick);
            this.pbxCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxCanvas_MouseDown);
            this.pbxCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxCanvas_Paint);
            this.pbxCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxCanvas_MouseUp);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(190, 728);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 774);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cbxKeepRatio);
            this.Controls.Add(this.tbZoomV);
            this.Controls.Add(this.tbZoom);
            this.Controls.Add(this.pbxCanvas);
            this.Controls.Add(this.ssLightScribeState);
            this.Controls.Add(this.tsQMenu);
            this.Controls.Add(this.msMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "frmMain";
            this.Text = "DVDScribe";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.tsQMenu.ResumeLayout(false);
            this.tsQMenu.PerformLayout();
            this.ssLightScribeState.ResumeLayout(false);
            this.ssLightScribeState.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoomV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem dVDScribeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsQMenu;
        private System.Windows.Forms.ToolStripButton tsbtnOpenFile;
        private System.Windows.Forms.ToolStripButton tsbtnReset;
        private System.Windows.Forms.ToolStripButton tsbtnPrintPreview;
        private System.Windows.Forms.StatusStrip ssLightScribeState;
        private System.Windows.Forms.PictureBox pbxCanvas;
        private System.Windows.Forms.TrackBar tbZoom;
        private System.Windows.Forms.ToolStripStatusLabel tsSoftwareState;
        private System.Windows.Forms.ToolStripStatusLabel tsDriveState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnEditOptions;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem;
        private System.Windows.Forms.TrackBar tbZoomV;
        private System.Windows.Forms.CheckBox cbxKeepRatio;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnDragMode;
        private System.Windows.Forms.ToolStripButton btnTextMode;
        private System.Windows.Forms.ToolStripButton btnImageMode;
        private System.Windows.Forms.ToolStripStatusLabel lbMode;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

