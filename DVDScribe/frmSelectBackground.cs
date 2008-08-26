using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DVDScribe
{
    public partial class frmSelectBackground : Form
    {
        public String SelectedFile
        {
            get
            {
                return lv.SelectedItems[0].Tag.ToString();
            }
        }

        public frmSelectBackground()
        {
            InitializeComponent();
            initDirlist();
        }

        private void initDirlist()
        {            
            TreeNode root = tvDirectory.Nodes.Add(System.Environment.MachineName, System.Environment.MachineName, 0);
            root.SelectedImageIndex = 0;
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                switch (drive.DriveType)
                {
                    case DriveType.CDRom:
                        {
                            TreeNode node = root.Nodes.Add(drive.Name, drive.Name, 3);
                            node.SelectedImageIndex = 3;
                        } break;
                    case DriveType.Fixed:
                        {
                            TreeNode node = root.Nodes.Add(drive.Name, drive.Name, 1);
                            node.SelectedImageIndex = 1;
                        } break;
                    case DriveType.Removable:
                        {
                            TreeNode node = root.Nodes.Add(drive.Name, drive.Name, 2);
                            node.SelectedImageIndex = 2;
                        } break;
                }
            }
            tvDirectory.Nodes[0].Expand();
        }
        private void populate_drive()
        {
            DriveInfo[] drvlist = DriveInfo.GetDrives();
            int cnt = drvlist.Length;
            int cntdrv = 0;
            foreach (DriveInfo lst in drvlist)
            {
                if (lst.DriveType == DriveType.CDRom)
                {

                    cntdrv++;
                }
                else
                {
                    DirectoryInfo di = new
                       DirectoryInfo(lst.ToString());
                    DirectoryInfo[] di_list =
                       di.GetDirectories();
                    foreach (DirectoryInfo lstdir in
                       di_list)
                    {
                        string n =
                          lstdir.Name.ToString();
                        tvDirectory.Nodes[0].Nodes
                          [cntdrv].Nodes.Add
                             (n, n, 1);
                        tvDirectory.Update();
                    }
                    cntdrv++;
                }


            }

        }
        private void Fill(TreeNode dirNode)
        {                       
            try
            {
                String root = dirNode.FullPath.Remove(0, System.Environment.MachineName.Length + 1);
                DirectoryInfo dir = new DirectoryInfo(root);
                dirNode.Nodes.Clear();
                
                foreach (DirectoryInfo dirItem in dir.GetDirectories())
                {
                    TreeNode newNode = dirNode.Nodes.Add(dirItem.Name, dirItem.Name, 4);
                    newNode.SelectedImageIndex = 5;
                } 
                ImageList imgList = new ImageList();
                imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
                imgList.ImageSize = new System.Drawing.Size(128, 128);
                lv.Items.Clear();
                lv.LargeImageList = imgList;
                foreach (FileInfo file in dir.GetFiles())
                {
                    if (file.Extension == ".jpg" || file.Extension == ".png" || file.Extension == ".bmp")
                    {
                        Image thumb = Image.FromFile(file.FullName);
                        imgList.Images.Add(thumb);

                        ListViewItem lvi = lv.Items.Add(file.Name);
                        lvi.ImageIndex = lvi.Index;
                        lvi.Tag = file.FullName;
                    }                                       
                }

                dirNode.Expand();
            }
            catch
            {
                return;
            }
        }

        private void tvDirectory_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.IsExpanded == false)
            {
                Fill(e.Node);
            }
            else
            {
                e.Node.Collapse();
            }
        }

        private void lv_DoubleClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
 
    }

}
