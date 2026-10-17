using System.Runtime.InteropServices;


namespace Lab02
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnBai01_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai01 bai01Form = new Bai01();
            bai01Form.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 1;
            this.Enabled = true;
            this.DoubleBuffered = true;
        }

        private void btnBai02_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai02 bai02Form = new Bai02();
            bai02Form.FormClosed += (s, args) => this.Show();
            bai02Form.ShowDialog();
        }

        private void btnBai03_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai03 bai03Form = new Bai03();
            bai03Form.ShowDialog();
            this.Show();
        }

        private void btnBai04_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai04 bai04Form = new Bai04();
            bai04Form.ShowDialog();
            this.Show();
        }

        private void btnBai05_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai05 bai05Form = new Bai05();
            bai05Form.ShowDialog();
            this.Show();
        }

        private void btnBai06_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai06 bai06Form = new Bai06();
            bai06Form.ShowDialog();
            this.Show();
        }

        private void btnBai07_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai07 bai07Form = new Bai07();
            bai07Form.ShowDialog();
            this.Show();
        }

        
    }
}
