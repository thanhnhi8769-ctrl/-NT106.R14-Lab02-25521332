# 🚀 LAB 02 — WINFORMS & DATA PROCESSING SUITE

![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)
![Status: Active](https://img.shields.io/badge/Status-Active-brightgreen.svg)
![C# .NET](https://img.shields.io/badge/C%23-.NET%20Framework-blue.svg)
![Visual Studio 2022](https://img.shields.io/badge/VS%202022-.slnx-purple.svg)

> **Tóm tắt ngắn gọn:** Hệ thống WinForms đa phân hệ (Lab02) gồm 7 bài tập thực hành toàn diện về I/O tập tin, thuật toán Dual-Stack, quản lý JSON/SQLite, giao diện Frameless tùy biến Win32 API và xử lý báo cáo LINQ trên chuẩn giải pháp Visual Studio 2022 (`.slnx`).

---

## 📸 Hình Ảnh & GIF Demo (Media & Previews)

| Demo Thao Tác (GIF) | Giao Diện Chi Tiết (Form) |
| :---: | :---: |
| ![GIF Demo](./Resources/cinema1.gif) | ![Form Chi Tiet](./Resources/cinema2.gif) |

*Hình 1: Minh họa giao diện điều hướng DashBoard và hiệu ứng nền GIF động trong hệ thống Lab02.*

---

## ✨ Tính Năng Nổi Bật (Features)

* 🎥 **Giao diện Frameless tùy biến & Win32 Interop:** Loại bỏ khung viền Windows truyền thống, tích hợp Win32 API (`ReleaseCapture`, `SendMessage` từ `user32.dll`) cho phép nhấp giữ chuột di chuyển Form linh hoạt.
* ⚡ **Chuẩn Giải pháp `.slnx` Hiện đại:** Tối ưu hóa cấu trúc dự án trên Visual Studio 2022 giúp nạp bài và quản lý tài nguyên cực nhanh.
* 🧮 **Động cơ Giải toán Dual-Stack (Bài 03):** Phân tích cú pháp và tự động tính toán chuỗi biểu thức toán học phức tạp đa dòng từ tập tin văn bản.
* 📋 **Quản Lý Sinh Viên JSON & Phân Trang (Bài 04):** Chuẩn hóa lưu trữ dữ liệu bằng `System.Text.Json`, kiểm tra Regex (MSSV 8 số, SĐT 10 số) và chuyển trang xem chi tiết.
* 🎟️ **Đặt Vé Rạp Phim & Báo Cáo Doanh Thu LINQ (Bài 05):** Sơ đồ ghế tương tác thời gian thực, tự động tính tiền theo hệ số vị trí ghế và lập báo cáo thống kê bằng **LINQ**.
* 🍜 **CSDL SQLite Quan Hệ & Quay Số Chọn Món (Bài 06):** Quản lý liên kết đa bảng (`MonAn` - `NguoiDung`) và gợi ý món ăn ngẫu nhiên với `ORDER BY RANDOM() LIMIT 1`.
* 📂 **File Explorer TreeView Lazy Loading (Bài 07):** Duyệt cấu trúc ổ đĩa hệ thống theo cơ chế nạp chậm (chỉ nạp thư mục con khi mở rộng nút) giúp tối ưu bộ nhớ RAM và hỗ trợ xem trước hình ảnh.

---

## 📖 Chi Tiết Các Form & Bảng Tra Cứu Trường Dữ Liệu

### 🎛️ DashBoard — Màn Hình Điều Hướng Trung Tâm
* **Hướng dẫn:** Nhấp vào nút từ `Bài 1` đến `Bài 7` để mở trực tiếp Form chức năng tương ứng.

---

### 📝 Bai01 — Đọc, Mã Hóa & Ghi Tập Tin Văn Bản
* **Hướng dẫn:** Bấm **Đọc File** để nạp `input1.txt`. Nhập/sửa nội dung tại ô văn bản. Bấm **Ghi File** để chuyển toàn bộ ký tự sang dạng IN HOA và lưu vào `output1.txt`.

| Trường Dữ Liệu / Control | Loại Control | Chức năng & Xử lý Kỹ thuật |
| :--- | :--- | :--- |
| `rtbNoiDung` | `RichTextBox` | Hiển thị nội dung đọc được hoặc nhận chuỗi nhập trực tiếp. |
| `btnDocFile` | `Button` | Tìm tệp `input1.txt` theo 3 cấp ưu tiên (Bin ➔ Project ➔ `OpenFileDialog`). |
| `btnGhiFile` | `Button` | Chuyển nội dung sang in hoa (`.ToUpper()`) và lưu vào `output1.txt`. |

---

### 🔍 Bai02 — Phân Tích Thuộc Tính Tệp & Thống Kê Văn Bản
* **Hướng dẫn:** Bấm **Read File** chọn tệp `.txt`. Hệ thống tự động trích xuất thuộc tính tệp và đếm các chỉ số cấu trúc văn bản.

| Trường Dữ Liệu / Control | Loại Control | Chức năng & Xử lý Kỹ thuật |
| :--- | :--- | :--- |
| `btnRead` | `Button` | Mở `OpenFileDialog` với bộ lọc chỉ định `.txt`. |
| `rtbContent` | `RichTextBox` | Khung xem toàn văn nội dung tệp. |
| `txtFileName` | `TextBox` | Tên tệp tin ngắn gọn (`SafeFileName`). |
| `txtURL` | `TextBox` | Đường dẫn tuyệt đối trên ổ đĩa. |
| `txtSize` | `TextBox` | Dung lượng chính xác tính bằng **bytes** (`FileInfo.Length`). |
| `txtCharCount` | `TextBox` | Tổng số lượng ký tự trong văn bản. |
| `txtLineCount` | `TextBox` | Tổng số dòng sau khi tách chuỗi `\r\n`. |
| `txtWordCount` | `TextBox` | Đếm chính xác số từ bằng Biểu thức chính quy Regex `@"\b\w+\b"`. |

---

### 🧮 Bai03 — Thuật Toán Dual-Stack Giải Biểu Thức Toán Học
* **Hướng dẫn:** Bấm **Đọc File** nạp phép toán. Bấm **Tính Toán** để giải. Bấm **Lưu File** để xuất kết quả ra file mới (chỉ kích hoạt khi $100\%$ biểu thức hợp lệ).

| Trường Dữ Liệu / Control | Loại Control | Chức năng & Xử lý Kỹ thuật |
| :--- | :--- | :--- |
| `rtbRead` | `RichTextBox` | Hiển thị danh sách biểu thức toán học đầu vào. |
| `btnCal` | `Button` | Thuật toán 2 Stack: Xử lý ưu tiên toán tử `+,-,*,/`, ngoặc `()` và tiền tố số âm `(-X)`. |
| `rtbCal` | `RichTextBox` | Hiển thị bảng kết quả dạng `[Biểu thức] = [Kết quả]`. |
| `btnSave` | `Button` | Ghi dữ liệu ra file `UTF-8` bằng `FileStream`. |

---

### 📋 Bai04 — Quản Lý Sinh Viên JSON & Điều Hướng Phân Trang
* **Hướng dẫn:** Nhập thông tin bên trái ➔ Bấm **Thêm** ➔ Bấm **Lưu File** để lưu JSON `input4.txt`. Bấm **Đọc File** để đọc `input4.txt`, tính ĐTB và xuất `output4.txt`. Bấm **Next** / **Back** để phân trang.

| Trường Dữ Liệu / Control | Loại Control | Quy chuẩn dữ liệu & Ràng buộc (Validation) |
| :--- | :--- | :--- |
| `txtName` / `txtNameRead` | `TextBox` | Họ tên sinh viên (Bắt buộc nhập). |
| `txtID` / `txtIDRead` | `TextBox` | Mã số sinh viên (Xác thực Regex: **Đúng 8 chữ số**). |
| `txtPhone` / `txtPhoneRead` | `TextBox` | Số điện thoại (Xác thực Regex: **Đúng 10 chữ số, bắt đầu bằng 0**). |
| `txtCourse1..3` | `TextBox` | Điểm 3 học phần (Thang điểm số thực từ `0.0` đến `10.0`). |
| `txtAverageRead` | `TextBox` | Điểm trung bình tự động tính: $\text{ĐTB} = \frac{D_1 + D_2 + D_3}{3}$. |
| `btnWriteFile` | `Button` | Tuần tự hóa `List<SinhVien>` sang JSON (`WriteIndented`) và lưu `input4.txt`. |
| `btnReadFile` | `Button` | Giải tuần tự hóa JSON, gọi `TinhDiemTB()` và xuất ra `output4.txt`. |
| `btnNext` / `btnBack` | `Button` | Điều hướng con trỏ `currentIndex` để chuyển trang xem chi tiết. |

---

### 🎟️ Bai05 — Hệ Thống Đặt Vé Rạp Phim & Báo Cáo Doanh Thu LINQ
* **Hướng dẫn:** 
  1. **Đặt vé:** Nhập tên khách hàng, chọn Phim ➔ Chuyển `BookingForm` ➔ Chọn Phòng ➔ Chọn ghế trên sơ đồ ➔ Bấm **Thanh toán**.
  2. **Quản trị:** Bấm **Quản trị** ➔ Nhập mật khẩu `admin123` ➔ Bấm **Thống kê** xem báo cáo LINQ ➔ Bấm **Lưu** xuất file `output5.txt`.

| Phân Hệ Form | Trường / Control | Vai Trò & Algorithmic Logic |
| :--- | :--- | :--- |
| **`Bai05`** | `txtTenKhachHang`, `cbPhim` | Nhập tên người mua và chọn phim chiếu. |
| **`BookingForm`** | `cbPhongChieu` | Tự động lọc các phòng chiếu tương ứng với phim đã chọn. |
| **`BookingForm`** | `panelGhe` (*Matrix*) | Sơ đồ ghế tương tác: **Xám** (Trống), **Xanh lá** (Đang chọn), **Đỏ** (Đã bán). |
| **`BookingForm`** | `lblTinhTien` | Tính tiền theo hệ số: Vé biên = $25\%$, VIP = $200\%$, Thường = $100\%$. |
| **`BookingForm`** | `btnThanhToan` | In hóa đơn, lưu vết vào `input5.txt` và cập nhật `booked_seats5.txt`. |
| **`PasswordForm`**| `txtPassword` | Ô nhập mật khẩu xác thực quản trị (`admin123`). |
| **`AdminForm`** | `btnXuatThongKe` | Đọc `input5.txt`, dùng **LINQ** `GroupBy` tính vé tồn, tỷ lệ lấp đầy (%), doanh thu và thứ hạng. |
| **`AdminForm`** | `btnLuu` | Xuất bảng tổng hợp doanh thu chi tiết ra file `output5.txt`. |

---

### 🍜 Bai06 — Quản Lý Thực Đơn & Gợi Ý Ngẫu Nhiên SQLite
* **Hướng dẫn:** Bấm **Thêm** mở `FormNhapLieu` để nhập Người dùng và Món ăn kèm ảnh. Bấm **Tìm món ăn** mở `FormKetQua` để quay số ngẫu nhiên chọn món.

| Phân Hệ Form | Trường / Control | Vai Trò & Truy Vấn CSDL |
| :--- | :--- | :--- |
| **`Bai06`** | `lvDanhSachMonAn` | Hiển thị kết quả truy vấn `SELECT m.IDMA, m.TenMonAn, n.HoVaTen FROM MonAn m LEFT JOIN NguoiDung n ON m.IDNCC = n.IDNCC`. |
| **`FormNhapLieu`**| `txtIDNCC`, `txtHoVaTen`, `cboQuyenHan` | Nhập thông tin người đóng góp và lưu vào bảng `NguoiDung`. |
| **`FormNhapLieu`**| `txtIDMA`, `txtTenMonAn`, `cboNguoiDongGop`, `btnChonAnh` | Nhập món ăn mới kèm đường dẫn ảnh vào bảng `MonAn`. |
| **`FormKetQua`** | `lblTenMonAn`, `lblNguoiDongGop`, `picKetQua` | Hiển thị món ăn chọn ngẫu nhiên bằng câu lệnh `ORDER BY RANDOM() LIMIT 1`. |

---

### 📂 Bai07 — Trình Quản Lý Tệp & Thư Mục (File Explorer)
* **Hướng dẫn:** Nhấp chọn từng thư mục trên cây `TreeView`. Khi nhấp chọn file ảnh (`.jpg`, `.png`, `.jpeg`, `.gif`), ảnh sẽ hiển thị trên khung `PictureBox`.

| Trường / Control | Loại Control | Chức năng & Xử lý Kỹ thuật |
| :--- | :--- | :--- |
| `tvFolderBrowser` | `TreeView` | Quét ổ đĩa hệ thống với cơ chế **Lazy Loading** (dùng gút giả `"dummy"`) chỉ tải thư mục con khi bấm mở rộng (`BeforeExpand`). |
| `picFileContent` | `PictureBox` | Tự động xem trước nội dung ảnh khi chọn file (`AfterSelect`). |

---

## ⚡ Hướng Dẫn Cài Đặt & Khởi Chạy

1. **Clone Repository về máy cá nhân:**
   ```bash
   git clone https://github.com/thanhnhi8769-ctrl/-NT106.R14-Lab02-25521332.git
   ```

2. **Mở dự án bằng Visual Studio 2022:**
   * Khởi động Visual Studio 2022.
   * Chọn **Open a project or solution** ➔ Chọn tệp giải pháp **`Lab02.slnx`**.

3. **Biên dịch & Khởi chạy (Build & Run):**
   * Nhấn phím `F5` hoặc chọn nút **Start** trên thanh công cụ để chạy màn hình `DashBoard`.