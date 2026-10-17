using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    string fullContent = sr.ReadToEnd();


                    txtFileName.Text = openFileDialog1.SafeFileName;

                    FileInfo fi = new FileInfo(openFileDialog1.FileName);
                    txtSize.Text = fi.Length.ToString() + " bytes";

                    txtURL.Text = openFileDialog1.FileName;

                    rtbContent.Text = fullContent;


                    int charCount = fullContent.Length;
                    txtCharCount.Text = charCount.ToString();

                    string[] lines = fullContent.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                    int lineCount = lines.Length;
                    txtLineCount.Text = lineCount.ToString();
                    int wordCount = CountWords(fullContent);
                    txtWordCount.Text = wordCount.ToString();
                }
            }
        }

        private int CountWords(string text)
        {
            MatchCollection matches = Regex.Matches(text, @"\b\w+\b");
            return matches.Count;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

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

       
    }
}
