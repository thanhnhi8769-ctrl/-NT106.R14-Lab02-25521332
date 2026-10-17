using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai07 : Form
    {
        public Bai07()
        {
            InitializeComponent();
            this.Load += Bai07_Load;
            tvFolderBrowser.BeforeExpand += TvFolderBrowser_BeforeExpand;
            tvFolderBrowser.AfterSelect += tvFolderBrowser_AfterSelect;
        }
        private void Bai07_Load(object sender, EventArgs e)
        {
            tvFolderBrowser.Nodes.Clear(); 

            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    TreeNode node = new TreeNode(drive.Name);
                    node.Tag = drive.RootDirectory.FullName; 
                    node.ImageIndex = 0;                     
                    node.SelectedImageIndex = 0;

                    node.Nodes.Add("dummy");

                    tvFolderBrowser.Nodes.Add(node);
                }
            }
        }
        private void TvFolderBrowser_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear();

            string path = node.Tag.ToString(); 

            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);

                
                foreach (DirectoryInfo subDir in dir.GetDirectories())
                {
                    TreeNode subNode = new TreeNode(subDir.Name);
                    subNode.Tag = subDir.FullName;
                    subNode.ImageIndex = 1;             
                    subNode.SelectedImageIndex = 1;
                    subNode.Nodes.Add("dummy");         
                    node.Nodes.Add(subNode);
                }

                foreach (FileInfo file in dir.GetFiles())
                {
                    TreeNode fileNode = new TreeNode(file.Name);
                    fileNode.Tag = file.FullName;
                    fileNode.ImageIndex = 2;            
                    fileNode.SelectedImageIndex = 2;
                    node.Nodes.Add(fileNode);
                }
            }
            catch (UnauthorizedAccessException)
            {
            }
        }
        private void tvFolderBrowser_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag.ToString();

            if (File.Exists(path))
            {
                string extension = Path.GetExtension(path).ToLower();

                if (extension == ".jpg" || extension == ".png" || extension == ".jpeg" || extension == ".gif")
                {
                    picFileContent.Visible = true;


                    picFileContent.Image = Image.FromFile(path);
                }
                else if (extension == ".txt")
                {
                    picFileContent.Visible = false;

                   
                }
                else
                {
                    picFileContent.Visible = false;
                }
            }
        }
       

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }
    }
}
