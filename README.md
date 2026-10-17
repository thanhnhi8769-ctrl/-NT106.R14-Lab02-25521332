# 🚀 LAB 02 — WINFORMS & DATA PROCESSING SUITE

![C# .NET](https://img.shields.io/badge/Language-C%23_8.0-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Framework](https://img.shields.io/badge/Framework-.NET_Framework_4.8_/_8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Database](https://img.shields.io/badge/Database-SQLite_3-07405E?style=for-the-badge&logo=sqlite&logoColor=white)
![IDE](https://img.shields.io/badge/IDE-Visual_Studio_2022-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)
![Format](https://img.shields.io/badge/Solution-.SLNX_Format-FF6F00?style=for-the-badge)

> [!IMPORTANT]
> **Tóm tắt dự án:** Hệ thống WinForms đa phân hệ **Lab02** giải quyết trọn vẹn các bài toán xử lý I/O tập tin, thuật toán Dual-Stack, quản lý cấu trúc JSON/SQLite, giao diện Frameless tùy biến phong cách **Neon Cyberpunk Glassmorphism** kết hợp hiệu ứng GIF động, cùng công cụ phân tích thống kê báo cáo nâng cao bằng **LINQ**.

---

## 📸 1. HÌNH ẢNH & GIAO DIỆN DEMO (MEDIA & PREVIEWS)

| 🎬 Giao Diện Chọn Phim & Link Quản Lý | 🎟️ Sơ Đồ Đặt Vé & Ma Trận Ghế |
| :---: | :---: |
| ![Select Movie Form](./Resources/cinema1.gif) | ![Booking Matrix Form](./Resources/cinema2.gif) |

> [!TIP]
> **Điểm nhấn thiết kế:** Giao diện Form `Bai05` áp dụng phong cách Tím Neon Cyberpunk kết hợp hiệu ứng ảnh GIF động (Cuộn phim & Bỏng ngô) được nạp trực tiếp qua `FrameDimension` & cơ chế `DoubleBuffered` chống xé hình, mang lại trải nghiệm như ứng dụng xem phim thương mại.

---

## ✨ 2. TÍNH NĂNG NỔI BẬT & ĐIỂM MẠNH KỸ THUẬT

### 🎨 1. Thiết Kế Giao Diện Tùy Biến (Frameless & Win32 Interop)
* **Khung viền tùy biến:** Loại bỏ hoàn toàn thanh tiêu đề Windows mặc định, tự thiết kế cụm nút điều khiển `[ - ]` (`btnMinimize`), `[ ▢ ]` (`btnMaximize`), `[ X ]` (`btnClose`).
* **Kéo thả di chuyển Form:** Nhúng trực tiếp Win32 API từ `user32.dll` (`ReleaseCapture` và `SendMessage` với tham số `WM_NCLBUTTONDOWN = 0xA1`) cho phép bấm giữ và di chuyển Form ở bất kỳ vị trí trống nào trên giao diện.

### 🧮 2. Động Cơ Thuật Toán Dual-Stack (Bài 03)
* Phân tích và xử lý chuỗi biểu thức toán học đa dòng từ tập tin văn bản.
* Hỗ trợ đầy đủ các toán tử `+`, `-`, `*`, `/`, dấu ngoặc đơn `()` và xử lý thông minh tiền tố số âm dạng `(-X)`.

### 📋 3. Chuẩn Hóa Dữ Liệu JSON & Regex Validation (Bài 04)
* Đóng gói và giải đóng gói chuỗi dữ liệu phức tạp bằng engine `System.Text.Json`.
* Ràng buộc dữ liệu đầu vào nghiêm ngặt bằng Biểu thức chính quy (Regex):
  * 🆔 **MSSV:** Bắt buộc đúng 8 chữ số (`@"^\d{8}$"`).
  * 📞 **Số điện thoại:** Bắt buộc đúng 10 chữ số và bắt đầu bằng số 0 (`@"^0\d{9}$"`).

### 🎟️ 4. Hệ Thống Đặt Vé Rạp Phim & Báo Cáo LINQ (Bài 05)
* **Sơ đồ ghế tương tác thời gian thực:** Tự động tạo ma trận ghế với 3 trạng thái màu phân biệt.
* **Công thức phân hạng giá vé:**
  * 🟡 **Vé Biên (A1, A5, B1, B5, C1, C5):** $50\%$ giá vé chuẩn ($40.000$ VNĐ).
  * 🔴 **Vé VIP (B2, B3, B4):** $200\%$ giá vé chuẩn ($160.000$ VNĐ).
  * 🔵 **Vé Thường (Các vị trí còn lại):** $100\%$ giá vé chuẩn ($80.000$ VNĐ).
* **Báo cáo LINQ Analytics:** Gom nhóm (`GroupBy`), tính tỷ lệ lấp đầy phòng chiếu (%), tổng doanh thu và xếp hạng phim bán chạy nhất.

### 🍜 5. Quản Lý CSDL Quan Hệ SQLite & Random Query (Bài 06)
* Thiết kế mô hình CSDL quan hệ chuẩn hóa với khóa ngoại (`Foreign Key`) nối giữa bảng `MonAn` và `NguoiDung`.
* Thuật toán gợi ý món ăn ngẫu nhiên thực thi trực tiếp dưới CSDL bằng câu lệnh `ORDER BY RANDOM() LIMIT 1`.

### 📂 6. File Explorer TreeView với Lazy Loading (Bài 07)
* Duyệt cấu trúc cây thư mục hệ thống tối ưu bộ nhớ RAM nhờ kỹ thuật **Lazy Loading** (Sử dụng gút giả `"dummy"` để chỉ nạp danh sách thư mục con khi người dùng nhấp mở rộng nút).

---

## 📖 3. BẢNG TRA CỨU CHI TIẾT DỮ LIỆU & HƯỚNG DẪN THAO TÁC CÁC FORM

### 🎛️ DashBoard — Màn Hình Điều Hướng Trung Tâm
* **Thao tác:** Bấm vào các nút bài tập tương ứng từ `Bài 1` đến `Bài 7` trên Menu điều hướng.

---

### 📝 Bai01 — Đọc, Mã Hóa & Ghi Tập Tin Văn Bản
* **Thao tác:** Bấm **Đọc File** để đọc `input1.txt` ➔ Sửa đổi văn bản trên khung ➔ Bấm **Ghi File** để viết HOA toàn bộ nội dung và xuất ra `output1.txt`.

| Control Name | Loại Control | Chức năng & Xử lý Kỹ thuật |
| :--- | :--- | :--- |
| `rtbNoiDung` | `RichTextBox` | Hiển thị nội dung đọc được hoặc nhận chuỗi nhập văn bản từ bàn phím. |
| `btnDocFile` | `Button` | Tìm tệp `input1.txt` theo 3 cấp ưu tiên (Bin ➔ Project ➔ `OpenFileDialog`). |
| `btnGhiFile` | `Button` | Kích hoạt phương thức `.ToUpper()` toàn bộ văn bản và lưu vào `output1.txt`. |

---

### 🔍 Bai02 — Phân Tích Thuộc Tính Tệp & Thống Kê Văn Bản
* **Thao tác:** Bấm **Read File** chọn tệp `.txt` bất kỳ ➔ Hệ thống tự động điền các thông số đường dẫn, dung lượng và chỉ số đếm.

| Control Name | Loại Control | Chức năng & Xử lý Kỹ thuật |
| :--- | :--- | :--- |
| `btnRead` | `Button` | Mở `OpenFileDialog` lọc các tệp tin đuôi `.txt`. |
| `rtbContent` | `RichTextBox` | Khung hiển thị toàn bộ nội dung tệp văn bản. |
| `txtFileName` | `TextBox` | Tên tệp tin ngắn gọn (`SafeFileName`). |
| `txtURL` | `TextBox` | Đường dẫn tuyệt đối của tệp tin trên hệ thống đĩa cứng. |
| `txtSize` | `TextBox` | Dung lượng tệp tính chính xác theo đơn vị **Bytes** (`FileInfo.Length`). |
| `txtCharCount` | `TextBox` | Tổng số lượng ký tự có trong văn bản. |
| `txtLineCount` | `TextBox` | Tổng số dòng thu được sau khi tách chuỗi `\r\n`. |
| `txtWordCount` | `TextBox` | Số lượng từ được tách chính xác bằng Regex `@"\b\w+\b"`. |

---

### 🧮 Bai03 — Thuật Toán Dual-Stack Giải Biểu Thức Toán Học
* **Thao tác:** Bấm **Đọc File** ➔ Bấm **Tính Toán** để giải biểu thức ➔ Bấm **Lưu File** để ghi kết quả (chỉ mở khóa nút lưu khi tất cả các dòng đều đúng cú pháp).

| Control Name | Loại Control | Chức năng & Xử lý Kỹ thuật |
| :--- | :--- | :--- |
| `rtbRead` | `RichTextBox` | Hiển thị chuỗi biểu thức đầu vào. |
| `btnCal` | `Button` | Thực thi thuật toán 2 Stack (OpStack & ValStack) tính toán theo đúng độ ưu tiên toán tử. |
| `rtbCal` | `RichTextBox` | Xuất danh sách kết quả dạng `[Biểu thức] = [Kết quả]`. |
| `btnSave` | `Button` | Xuất tập tin văn bản mã hóa `UTF-8` qua `FileStream`. |

---

### 📋 Bai04 — Quản Lý Sinh Viên JSON & Phân Trang
* **Thao tác:** Nhập dữ liệu bên trái ➔ Bấm **Thêm** ➔ Bấm **Lưu File** để đóng gói JSON ra `input4.txt`. Bấm **Đọc File** để đọc `input4.txt`, tính ĐTB và lưu `output4.txt`. Bấm **Next** / **Back** để chuyển trang.

| Control Name | Loại Control | Quy chuẩn Dữ liệu & Ràng buộc (Validation) |
| :--- | :--- | :--- |
| `txtName` / `txtNameRead` | `TextBox` | Họ và tên sinh viên (Không được để trống). |
| `txtID` / `txtIDRead` | `TextBox` | Mã số sinh viên (**Regex: Đúng 8 chữ số**). |
| `txtPhone` / `txtPhoneRead` | `TextBox` | Số điện thoại (**Regex: Đúng 10 chữ số, bắt đầu bằng 0**). |
| `txtCourse1..3` | `TextBox` | Điểm 3 học phần (Số thực từ `0.0` đến `10.0`). |
| `txtAverageRead` | `TextBox` | Điểm trung bình tự động: $\text{ĐTB} = \frac{\text{Điểm}_1 + \text{Điểm}_2 + \text{Điểm}_3}{3}$. |
| `btnWriteFile` | `Button` | Serialized danh sách sinh viên sang JSON và lưu vào `input4.txt`. |
| `btnReadFile` | `Button` | Deserialized file `input4.txt`, tính ĐTB và xuất kết quả ra `output4.txt`. |
| `btnNext` / `btnBack` | `Button` | Tăng/giảm chỉ số trang `currentIndex` để xem chi tiết từng sinh viên. |

---

### 🎟️ Bai05 — Hệ Thống Đặt Vé Rạp Phim & Quản Lý Hệ Thống LINQ

> [!NOTE]
> **Quy trình thao tác:**
> 1. **Khách đặt vé:** Nhập tên vào `Customer Name` ➔ Bấm chọn Poster phim (hoặc dùng phím `Tab`/`Enter`) ➔ Mở Form `BookingForm` ➔ Chọn phòng chiếu ➔ Click chọn các vị trí ghế trên ma trận ➔ Bấm **Thanh toán**.
> 2. **Chế độ Quản trị:** Tại góc dưới cùng bên phải Form chọn phim, bấm trực tiếp vào link **`⚙ Quản lý hệ thống`** ➔ Mở Form `PasswordForm` ➔ Nhập mật khẩu `admin123` ➔ Mở Form `AdminForm` ➔ Bấm **Thống kê** để xem báo cáo LINQ và bấm **Lưu** để xuất `output5.txt`.

#### Bảng Tra Cứu Các Trường Control Chi Tiết:

| Form | Control Name | Loại Control | Chức năng & Xử lý Kỹ thuật |
| :--- | :--- | :--- | :--- |
| **`Bai05`** | `txtTenKhachHang` | `TextBox` | Ô nhập tên khách hàng (`Customer Name`). |
| **`Bai05`** | `picDaoPhoPiano`, `picMai`, `picGapLaiChiBau`, `picTarot` | `PictureBox` | Danh sách Poster 4 phim chiếu rạp. Click chọn hoặc di chuyển Tab/Enter để chọn phim. |
| **`Bai05`** | `lblQuanLyHeThong` | `LinkLabel` | **[LINK GÓC DƯỚI BÊN PHẢI]** Bấm vào link **`⚙ Quản lý hệ thống`** để mở cửa sổ xác thực quản trị. |
| **`BookingForm`**| `cbPhongChieu` | `ComboBox` | Chọn phòng chiếu (Rạp 1, Rạp 2, Rạp 3). Tự động cập nhật ma trận ghế tương ứng. |
| **`BookingForm`**| `pnlGhe` (*Matrix*) | `Panel` / `Button` | Ma trận 15 ghế tương tác: **Xám** (Trống), **Xanh lá** (Đang chọn), **Đỏ** (Đã bán/Khóa). |
| **`BookingForm`**| `lblTinhTien` | `Label` | Tự động tính tổng tiền theo hệ số loại vé (Vé biên $50\%$, VIP $200\%$, Thường $100\%$). |
| **`BookingForm`**| `btnThanhToan` | `Button` | In hóa đơn, lưu vết giao dịch vào `input5.txt` và ghi nhận vị trí ghế vào `booked_seats5.txt`. |
| **`PasswordForm`**| `txtPassword` | `TextBox` | Ô nhập mật khẩu truy cập hệ thống quản lý (Mật khẩu mặc định: `admin123`). |
| **`AdminForm`** | `btnXuatThongKe` | `Button` | Thực thi các truy vấn **LINQ** `GroupBy` phân tích tổng số vé bán, vé tồn, tỷ lệ lấp đầy % và doanh thu. |
| **`AdminForm`** | `btnLuu` | `Button` | Ghi bảng tổng hợp doanh thu chi tiết ra file `output5.txt`. |

---

### 🍜 Bai06 — Quản Lý Thực Đơn & Quay Số Chọn Món SQLite
* **Thao tác:** Bấm **Thêm** để mở `FormNhapLieu` (Thêm Người đóng góp & Món ăn kèm ảnh) ➔ Bấm **Tìm món ăn** để mở `FormKetQua` và nhận gợi ý món ăn ngẫu nhiên.

| Form | Control Name | Loại Control | Vai Trò & Truy Vấn CSDL |
| :--- | :--- | :--- | :--- |
| **`Bai06`** | `lvDanhSachMonAn` | `ListView` | Hiển thị bảng món ăn từ câu lệnh `SELECT m.IDMA, m.TenMonAn, n.HoVaTen FROM MonAn m LEFT JOIN NguoiDung n ON m.IDNCC = n.IDNCC`. |
| **`FormNhapLieu`**| `txtIDNCC`, `txtHoVaTen`, `cboQuyenHan` | `TextBox` / `ComboBox` | Nhập thông tin Người đóng góp ➔ Lưu vào bảng `NguoiDung`. |
| **`FormNhapLieu`**| `txtIDMA`, `txtTenMonAn`, `cboNguoiDongGop`, `btnChonAnh` | `TextBox` / `Button` | Nhập thông tin Món ăn mới kèm đường dẫn file ảnh ➔ Lưu vào bảng `MonAn`. |
| **`FormKetQua`** | `lblTenMonAn`, `lblNguoiDongGop`, `picKetQua` | `Label` / `PictureBox` | Hiển thị Món ăn chọn ngẫu nhiên bằng truy vấn `ORDER BY RANDOM() LIMIT 1`. |

---

### 📂 Bai07 — Trình Quản Lý Tệp & Thư Mục (File Explorer)
* **Thao tác:** Nhấp chọn các nhánh trên cây `TreeView` để duyệt thư mục hệ thống. Nhấp chọn các tập tin hình ảnh (`.jpg`, `.png`, `.jpeg`, `.gif`) để xem nội dung trực tiếp trên `PictureBox`.

| Control Name | Loại Control | Chức năng & Xử lý Kỹ thuật |
| :--- | :--- | :--- |
| `tvFolderBrowser` | `TreeView` | Quét cấu trúc ổ đĩa hệ thống. Áp dụng kỹ thuật **Lazy Loading** (Sử dụng gút giả `"dummy"`) chỉ nạp cây con khi bấm mở rộng nút (`BeforeExpand`). |
| `picFileContent` | `PictureBox` | Tải và xem trước nội dung tệp tin ảnh khi nhấp chọn nút file (`AfterSelect`). |

---

## ⚡ 4. HƯỚNG DẪN CÀI ĐẶT & KHỞI CHẠY

1. **Clone Repository về máy cá nhân:**
   ```bash
   git clone https://github.com/thanhnhi8769-ctrl/-NT106.R14-Lab02-25521332.git
   ```

2. **Mở dự án bằng Visual Studio 2022:**
   * Khởi động Visual Studio 2022 (Phiên bản 17.0 trở lên).
   * Chọn **Open a project or solution**.
   * Trỏ tới thư mục dự án và chọn tệp giải pháp **`Lab02.slnx`**.

3. **Biên dịch & Khởi chạy (Build & Run):**
   * Nhấn phím `F5` hoặc chọn nút **Start** trên thanh công cụ để trải nghiệm ứng dụng từ màn hình `DashBoard`.