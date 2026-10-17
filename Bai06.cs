using HomNayAnGi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
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
        private void pictureMouseDown_MouseDown(object sender, MouseEventArgs e)
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
        private void Bai06_Load(object sender, EventArgs e)
        {
            DatabaseHelper.InitializeDatabase();
            CauHinhListView();
            TaiDanhSachMonAn();

            Image gifImg = Properties.Resources.Gemini_Generated_Gif_z5mvo5z5mvo5z5mv;
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
        private void CauHinhListView()
        {
            lvDanhSachMonAn.View = View.Details;
            lvDanhSachMonAn.FullRowSelect = true;
            lvDanhSachMonAn.GridLines = true;
            lvDanhSachMonAn.Columns.Clear();

            lvDanhSachMonAn.Columns.Add("Mã Món", 100);   
            lvDanhSachMonAn.Columns.Add("Tên Món Ăn", 250);     
            lvDanhSachMonAn.Columns.Add("Người Đóng Góp", 220); 
        }

        public void TaiDanhSachMonAn()
        {
            lvDanhSachMonAn.Items.Clear();
            using (var conn = new SQLiteConnection(DatabaseHelper.connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT m.IDMA, m.TenMonAn, n.HoVaTen 
                    FROM MonAn m 
                    LEFT JOIN NguoiDung n ON m.IDNCC = n.IDNCC";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["IDMA"].ToString());
                        item.SubItems.Add(reader["TenMonAn"].ToString());
                        item.SubItems.Add(reader["HoVaTen"] != DBNull.Value ? reader["HoVaTen"].ToString() : "Chưa xác định");
                        lvDanhSachMonAn.Items.Add(item);
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNhapLieu frm = new FormNhapLieu(this);
            frm.ShowDialog();
            this.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDanhSachMonAn.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món ăn cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idma = lvDanhSachMonAn.SelectedItems[0].Text;
            var result = MessageBox.Show($"Bạn có chắc muốn xóa món ăn có mã {idma}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (var conn = new SQLiteConnection(DatabaseHelper.connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM MonAn WHERE IDMA = @idma";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idma", idma);
                        cmd.ExecuteNonQuery();
                    }
                }
                TaiDanhSachMonAn();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimMonNgauNhien_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKetQua frm = new FormKetQua();
            frm.ShowDialog();
            this.Show();
        }
    }
}
