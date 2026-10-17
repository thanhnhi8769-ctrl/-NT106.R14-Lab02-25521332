using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai04 : Form
    {
        private List<SinhVien> danhSachNhap = new List<SinhVien>();

        private List<SinhVien> danhSachHienThi = new List<SinhVien>();
        private int currentIndex = 0;
        public Bai04()
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

        

       

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (danhSachHienThi != null && currentIndex < danhSachHienThi.Count - 1)
            {
                currentIndex++;
                HienThiSinhVien(currentIndex);
            }
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string hoTen = txtName.Text.Trim();
                string idStr = txtID.Text.Trim();
                string dienThoai = txtPhone.Text.Trim();

                if (string.IsNullOrWhiteSpace(hoTen))
                {
                    MessageBox.Show("Vui lòng nhập họ và tên sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!Regex.IsMatch(idStr, @"^\d{8}$"))
                {
                    MessageBox.Show("Mã số sinh viên (ID) phải có đúng 8 chữ số!", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int mssv = int.Parse(idStr);

                if (!Regex.IsMatch(dienThoai, @"^0\d{9}$"))
                {
                    MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng số 0!", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!float.TryParse(txtCourse1.Text.Trim(), out float d1) || d1 < 0 || d1 > 10 ||
                    !float.TryParse(txtCourse2.Text.Trim(), out float d2) || d2 < 0 || d2 > 10 ||
                    !float.TryParse(txtCourse3.Text.Trim(), out float d3) || d3 < 0 || d3 > 10)
                {
                    MessageBox.Show("Điểm các học phần phải từ 0 đến 10!", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SinhVien sv = new SinhVien(hoTen, mssv, dienThoai, d1, d2, d3);
                danhSachNhap.Add(sv);

                rtbDisplay.AppendText($"{sv.HoTen}\n{sv.MSSV}\n{sv.DienThoai}\n{sv.DiemMon1}\n{sv.DiemMon2}\n{sv.DiemMon3}\n\n");

                txtName.Clear();
                txtID.Clear();
                txtPhone.Clear();
                txtCourse1.Clear();
                txtCourse2.Clear();
                txtCourse3.Clear();
                txtAverage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (danhSachNhap.Count == 0)
                {
                    MessageBox.Show("Chưa có sinh viên nào trong danh sách để ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string jsonString = JsonSerializer.Serialize(danhSachNhap, new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText("input4.txt", jsonString);

                MessageBox.Show("Đã ghi thành công vào file input4.txt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("input4.txt"))
                {
                    MessageBox.Show("File input4.txt không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string jsonInput = File.ReadAllText("input4.txt");
                danhSachHienThi = JsonSerializer.Deserialize<List<SinhVien>>(jsonInput);

                if (danhSachHienThi == null || danhSachHienThi.Count == 0)
                {
                    MessageBox.Show("Dữ liệu trong file rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                rtbDisplay.Clear();
                foreach (var sv in danhSachHienThi)
                {
                    sv.TinhDiemTB();
                    rtbDisplay.AppendText($"{sv.HoTen}\n{sv.MSSV}\n{sv.DienThoai}\n{sv.DiemMon1}\n{sv.DiemMon2}\n{sv.DiemMon3}\nĐTB: {sv.DiemTB}\n-------------------\n");
                }

                string jsonOutput = JsonSerializer.Serialize(danhSachHienThi, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("output4.txt", jsonOutput);

                currentIndex = 0;
                HienThiSinhVien(currentIndex);

                MessageBox.Show("Đã đọc file, tính ĐTB và ghi thành công vào output4.txt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiSinhVien(int index)
        {
            if (danhSachHienThi != null && index >= 0 && index < danhSachHienThi.Count)
            {
                SinhVien sv = danhSachHienThi[index];
                txtNameRead.Text = sv.HoTen;
                txtIDRead.Text = sv.MSSV.ToString();
                txtPhoneRead.Text = sv.DienThoai;
                txtCourse1Read.Text = sv.DiemMon1.ToString();
                txtCourse2Read.Text = sv.DiemMon2.ToString();
                txtCourse3Read.Text = sv.DiemMon3.ToString();
                txtAverageRead.Text = sv.DiemTB.ToString();

                lblPageIndicator.Text = (index + 1).ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (danhSachHienThi != null && currentIndex > 0)
            {
                currentIndex--;
                HienThiSinhVien(currentIndex);
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
