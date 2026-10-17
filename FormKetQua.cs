using HomNayAnGi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
namespace Lab02
{
    public partial class FormKetQua : Form
    {
        public FormKetQua()
        {
            InitializeComponent();
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

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
        private int currentFrame = 0;
        private int frameCount = 0;
        private FrameDimension dimension;
        private void FormKetQua_Load(object sender, EventArgs e)
        {
            ChonMonAnNgauNhien();

            Image gifImg = Properties.Resources.Gemini_Generated_Gif_xukayhxukayhxuka;
            bg.Image = gifImg;
            bg.SendToBack();

            if (gifImg != null && gifImg.FrameDimensionsList.Length > 0)
            {
                dimension = new FrameDimension(gifImg.FrameDimensionsList[0]);
                frameCount = gifImg.GetFrameCount(dimension);

                System.Windows.Forms.Timer timerGif = new System.Windows.Forms.Timer();
                timerGif.Interval = 120;
                timerGif.Tick += (s, ev) =>
                {
                    if (bg.Image != null && frameCount > 0)
                    {
                        currentFrame = (currentFrame + 1) % frameCount;
                        bg.Image.SelectActiveFrame(dimension, currentFrame);
                        bg.Invalidate();
                    }
                };
                timerGif.Start();
            }
        }
        private void ChonMonAnNgauNhien()
        {
            using (var conn = new SQLiteConnection(DatabaseHelper.connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT m.TenMonAn, m.HinhAnh, n.HoVaTen 
                    FROM MonAn m 
                    LEFT JOIN NguoiDung n ON m.IDNCC = n.IDNCC 
                    ORDER BY RANDOM() LIMIT 1";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblTenMonAn.Text = reader["TenMonAn"].ToString();

                        string nguoiDongGop = reader["HoVaTen"] != DBNull.Value ? reader["HoVaTen"].ToString() : "Ẩn danh";
                        lblNguoiDongGop.Text = $"Đóng góp bởi: {nguoiDongGop}";

                        string duongDanAnh = reader["HinhAnh"].ToString();
                        if (!string.IsNullOrEmpty(duongDanAnh) && File.Exists(duongDanAnh))
                        {
                            picKetQua.Image = Image.FromFile(duongDanAnh);
                            picKetQua.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        else
                        {
                            picKetQua.Image = null; 
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chưa có món ăn nào trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    }
                }
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            ChonMonAnNgauNhien();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
