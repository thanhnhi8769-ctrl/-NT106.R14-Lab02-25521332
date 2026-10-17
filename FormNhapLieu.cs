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
    public partial class FormNhapLieu : Form
    {
        private Bai06 formMain;
        private string duongDanAnh = "";
        public FormNhapLieu(Bai06 mainForm)
        {
            InitializeComponent();
            this.formMain = mainForm;
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

        private void pictureBoxMouseDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void btnLuuNguoiDung_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDNCC.Text) || string.IsNullOrWhiteSpace(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã người dùng và Họ tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var conn = new SQLiteConnection(DatabaseHelper.connectionString))
            {
                conn.Open();
                string query = "INSERT INTO NguoiDung (IDNCC, HoVaTen, QuyenHan) VALUES (@idncc, @ten, @quyen)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idncc", txtIDNCC.Text.Trim());
                    cmd.Parameters.AddWithValue("@ten", txtHoVaTen.Text.Trim());
                    cmd.Parameters.AddWithValue("@quyen", cboQuyenHan.SelectedItem?.ToString() ?? "User");

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TaiDanhSachNguoiDungVaoComboBox();
                        txtIDNCC.Clear();
                        txtHoVaTen.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
        private int currentFrame = 0;
        private int frameCount = 0;
        private FrameDimension dimension;

        private void FormNhapLieu_Load(object sender, EventArgs e)
        {
            TaiDanhSachNguoiDungVaoComboBox();
            cboQuyenHan.Items.AddRange(new string[] { "Admin", "User" });
            if (cboQuyenHan.Items.Count > 0) cboQuyenHan.SelectedIndex = 1;

            Image gifImg = Properties.Resources.Gemini_Generated_Gif_n8xi11n8xi11n8xi;
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
        private void TaiDanhSachNguoiDungVaoComboBox()
        {
            using (var conn = new SQLiteConnection(DatabaseHelper.connectionString))
            {
                conn.Open();
                string query = "SELECT IDNCC, HoVaTen FROM NguoiDung";
                using (var adapter = new SQLiteDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cboNguoiDongGop.DataSource = dt;
                    cboNguoiDongGop.DisplayMember = "HoVaTen";
                    cboNguoiDongGop.ValueMember = "IDNCC";
                }
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png)|*.jpg; *.jpeg; *.gif; *.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    duongDanAnh = open.FileName;
                    picHinhAnhMonAn.Image = Image.FromFile(duongDanAnh);
                    picHinhAnhMonAn.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void btnLuuMonAn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDMA.Text) || string.IsNullOrWhiteSpace(txtTenMonAn.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã món và Tên món ăn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var conn = new SQLiteConnection(DatabaseHelper.connectionString))
            {
                conn.Open();
                string query = "INSERT INTO MonAn (IDMA, TenMonAn, HinhAnh, IDNCC) VALUES (@idma, @ten, @anh, @idncc)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idma", txtIDMA.Text.Trim());
                    cmd.Parameters.AddWithValue("@ten", txtTenMonAn.Text.Trim());
                    cmd.Parameters.AddWithValue("@anh", duongDanAnh);
                    cmd.Parameters.AddWithValue("@idncc", cboNguoiDongGop.SelectedValue ?? DBNull.Value);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        formMain.TaiDanhSachMonAn();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi (có thể trùng mã món): " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
