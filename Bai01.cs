using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai01 : Form
    {
        private string inputPath = "input1.txt";
        private string outputPath = "output1.txt";
        public Bai01()
        {
            InitializeComponent();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            try
            {
                string projectPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
                string inputPath = Path.Combine(projectPath, "input1.txt");


                if (File.Exists("input1.txt"))
                {
                    using (StreamReader reader = new StreamReader("input1.txt"))
                    {
                        rtbNoiDung.Text = reader.ReadToEnd();
                    }
                }
                else if (File.Exists(inputPath))
                {
                    using (StreamReader reader = new StreamReader(inputPath))
                    {
                        rtbNoiDung.Text = reader.ReadToEnd();
                    }
                }
                else
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.FileName = "input1.txt";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                        {
                            rtbNoiDung.Text = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            try
            {
                string content = rtbNoiDung.Text;

                string upperContent = content.ToUpper();

                using (StreamWriter writer = new StreamWriter(outputPath))
                {
                    writer.Write(upperContent);
                }

                MessageBox.Show("Đã ghi thành công nội dung in hoa vào file output1.txt!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelMouseDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }

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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        
    }
}
