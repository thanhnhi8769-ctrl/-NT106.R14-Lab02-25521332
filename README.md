🚀 LAB 02 — ADVANCED WINFORMS \& DATA PROCESSING SUITEGiải pháp Lập trình Giao diện Windows Forms \& Xử lý Dữ liệu Toàn diệnĐược tối ưu hóa hoàn toàn cho cấu trúc giải pháp Visual Studio 2022 (.slnx)📌 1. TỔNG QUAN DỰ ÁNLab02 là bộ ứng dụng WinForms chuyên sâu gồm 7 phân hệ độc lập, được thiết kế theo mô hình kiến trúc hướng đối tượng (OOP) vững chắc. Dự án cung cấp giải pháp xử lý toàn diện cho các bài toán từ thao tác tập tin hệ thống, thuật toán phân tích cú pháp, quản lý dữ liệu cấu trúc (JSON/SQLite), đến hệ thống đặt vé rạp chiếu phim đa màn hình và trình duyệt tập tin tối ưu bộ nhớ.🏗️ 2. KIẾN TRÚC \& CÔNG NGHỆ TÍCH HỢP                          ┌──────────────────────────────────────────┐

&#x20;                         │         DashBoard (Form Điều Phối)       │

&#x20;                         └────────────────────┬─────────────────────┘

&#x20;                                              │

&#x20;  ┌─────────────┬─────────────┬───────────────┼───────────────┬─────────────┬─────────────┐

&#x20;  ▼             ▼             ▼               ▼               ▼             ▼             ▼

┌──────┐      ┌──────┐      ┌──────┐        ┌──────┐        ┌──────┐      ┌──────┐      ┌──────┐

│Bai01 │      │Bai02 │      │Bai03 │        │Bai04 │        │Bai05 │      │Bai06 │      │Bai07 │

└──────┘      └──────┘      └──────┘        └──────┘        └──────┘      └──────┘      └──────┘

File I/O      Metadata      Dual-Stack       JSON \&         Cinema System SQLite \&      File Tree

In hoa        \& Regex       Math Engine     Pagination      \& LINQ        GIF Engine    Lazy Load

Modern Solution Format: Sử dụng định dạng tệp giải pháp thế hệ mới Lab02.slnx của Visual Studio 2022.Custom Frameless Window Engine: Loại bỏ khung viền truyền thống, tích hợp bộ nút điều hướng tùy chỉnh (Close, Minimize, Maximize).Win32 API Interop Pattern: Tích hợp ReleaseCapture \& SendMessage (user32.dll) xử lý sự kiện kéo thả di chuyển Form linh hoạt.High-Performance GIF Decoder: Giải mã đa khung hình qua FrameDimension \& Timer tạo hiệu ứng nền động mượt mà.Relational Database Engine: Xử lý CSDL SQLite (System.Data.SQLite) với truy vấn tham số chống SQL Injection.Modern JSON Serialization: Tự động hóa trao đổi dữ liệu qua System.Text.Json.LINQ Data Analytics: Gom nhóm, tính toán tỷ lệ, xếp hạng và xuất báo cáo dữ liệu linh hoạt.📁 3. CẤU TRÚC REPOSITORYPlaintext-NT106.R14-Lab02-25521332/

├── .gitignore                      # Cấu hình loại bỏ tập tin rác (bin/, obj/, .vs/)

├── Lab02.slnx                      # File Solution chính (Visual Studio 2022 XML Format)

├── Lab02.csproj                    # File cấu hình Project C#

├── Program.cs                      # Điểm khởi chạy ứng dụng (Entry point)

│

├── 📂 Core \& Shared Resources

│   ├── DatabaseHelper.cs           # Tự động khởi tạo Schema \& Kết nối CSDL SQLite

│   ├── SinhVien.cs                 # Data Model Sinh viên \& Thuật toán tính ĐTB

│   ├── ThongKePhim.cs              # Data Model LINQ Báo cáo doanh thu Phim

│   └── Properties/                 # Managed Resources \& Assembly Info

│

├── 📂 Application Forms \& Logic

│   ├── DashBoard.cs                # Form điều phối trung tâm

│   ├── Bai01.cs                    # Phân hệ Đọc/Ghi file \& Chuyển chữ In hoa

│   ├── Bai02.cs                    # Phân hệ Trích xuất Metadata \& Thống kê Regex

│   ├── Bai03.cs                    # Phân hệ Thuật toán Dual-Stack tính toán biểu thức

│   ├── Bai04.cs                    # Phân hệ Quản lý Sinh viên JSON \& Phân trang

│   ├── Bai05.cs                    # Form khởi tạo hệ thống Rạp chiếu phim

│   ├── BookingForm.cs              # Phân hệ Đặt vé \& Sơ đồ ghế tương tác

│   ├── PasswordForm.cs             # Phân hệ Xác thực Quản trị viên

│   ├── AdminForm.cs                # Phân hệ Báo cáo LINQ \& Thống kê Doanh thu

│   ├── Bai06.cs                    # Phân hệ Quản lý Thực đơn \& Gợi ý SQLite

│   ├── FormNhapLieu.cs             # Phân hệ Nhập liệu Món ăn / Người dùng

│   ├── FormKetQua.cs               # Phân hệ Quay số Ngẫu nhiên (SQLite Random)

│   └── Bai07.cs                    # Phân hệ Trình duyệt File Explorer (Lazy Loading)

└── README.md                       # Tài liệu hướng dẫn sử dụng hệ thống

📖 4. CHI TIẾT CÁC PHÂN HỆ \& BẢNG TRA CỨU TRƯỜNG DỮ LIỆU🎛️ DashBoard — Màn Hình Điều Hướng Trung TâmThao tác 1-Click mở trực tiếp các cửa sổ bài tập từ Bai01 đến Bai07.📝 Bai01 — Đọc, Mã Hóa \& Ghi Tập Tin Văn BảnChức năng: Đọc file văn bản, chuyển toàn bộ ký tự sang dạng chữ in hoa và xuất ra file đích.Chi tiết trường \& Thao tác:Trường Dữ Liệu / ControlLoại ControlChức năng \& Xử lý Kỹ thuậtrtbNoiDungRichTextBoxHiển thị văn bản đọc được hoặc nhận chuỗi nhập trực tiếp từ người dùng.btnDocFileButtonTìm tệp input1.txt theo 3 cấp ưu tiên (Bin ➔ Project ➔ OpenFileDialog).btnGhiFileButtonChuyển nội dung sang in hoa (.ToUpper()) và lưu vào output1.txt.🔍 Bai02 — Phân Tích Thuộc Tính Tệp \& Thống Kê Văn BảnChức năng: Trích xuất siêu dữ liệu (Metadata) của tệp tin và phân tích chỉ số cấu trúc văn bản.Chi tiết trường \& Thao tác:Trường Dữ Liệu / ControlLoại ControlChức năng \& Xử lý Kỹ thuậtbtnReadButtonKhởi chạy OpenFileDialog với bộ lọc chỉ định .txt.rtbContentRichTextBoxKhung xem nội dung toàn văn của tệp tin.txtFileNameTextBoxTên tệp tin ngắn gọn lấy từ SafeFileName.txtURLTextBoxĐường dẫn tuyệt đối của tệp tin trên đĩa cứng.txtSizeTextBoxDung lượng chính xác tính bằng đơn vị bytes (FileInfo.Length).txtCharCountTextBoxTổng số lượng ký tự trong văn bản (fullContent.Length).txtLineCountTextBoxTổng số dòng thu được sau khi tách chuỗi \\r\\n.txtWordCountTextBoxĐếm chính xác số từ bằng Biểu thức chính quy Regex @"\\b\\w+\\b".🧮 Bai03 — Thuật Toán Dual-Stack Giải Biểu Thức Toán HọcChức năng: Tự động giải danh sách biểu thức toán học phức tạp đa dòng từ tệp văn bản.Chi tiết trường \& Thao tác:Trường Dữ Liệu / ControlLoại ControlChức năng \& Xử lý Kỹ thuậtrtbReadRichTextBoxHiển thị các biểu thức toán học đầu vào nạp từ file.btnCalButtonThực thi thuật toán 2 Stack: Xử lý độ ưu tiên operator, toán tử +,-,\*,/, dấu ngoặc () và chuẩn hóa tiền tố số âm (-X).rtbCalRichTextBoxXuất bảng kết quả dạng \[Biểu thức] = \[Kết quả].btnSaveButtonGhi kết quả ra file UTF-8 bằng FileStream. Ràng buộc: Chỉ cho phép lưu khi $100\\%$ các dòng biểu thức đều tính toán hợp lệ.📋 Bai04 — Quản Lý Sinh Viên JSON \& Điều Hướng Phân TrangChức năng: Nhập dữ liệu sinh viên có kiểm tra chuẩn hóa, lưu/đọc file JSON và chuyển trang xem chi tiết.Chi tiết trường \& Thao tác:Trường Dữ Liệu / ControlLoại ControlQuy chuẩn dữ liệu \& Ràng buộc (Validation)txtName / txtNameReadTextBoxHọ và tên sinh viên (Bắt buộc, không để trống).txtID / txtIDReadTextBoxMã số sinh viên (Kiểm tra Regex: Đúng 8 chữ số).txtPhone / txtPhoneReadTextBoxSố điện thoại (Kiểm tra Regex: Đúng 10 chữ số, bắt đầu bằng 0).txtCourse1..3TextBoxĐiểm môn 1, 2, 3 (Thang điểm số thực từ 0.0 đến 10.0).txtAverageReadTextBoxĐiểm trung bình tự động tính: $\\text{ĐTB} = \\frac{D\_1 + D\_2 + D\_3}{3}$.btnWriteFileButtonChuyển đổi danh sách sang chuỗi JSON có thụt lề (WriteIndented) và lưu input4.txt.btnReadFileButtonGiải tuần tự hóa JSON input4.txt, tính ĐTB và xuất bản ghi mới ra output4.txt.btnNext / btnBackButtonĐiều hướng con trỏ currentIndex để chuyển trang xem chi tiết.lblPageIndicatorLabelHiển thị vị trí trang hồ sơ hiện tại (Index + 1).🎟️ Bai05 — Hệ Thống Đặt Vé Rạp Phim \& Báo Cáo Doanh Thu LINQChức năng: Phân hệ đa màn hình quản lý lịch chiếu, sơ đồ đặt ghế thời gian thực và báo cáo doanh thu LINQ.Chi tiết trường \& Thao tác:Phân Hệ FormTrường ControlVai Trò \& Thuật Toán Xử LýBai05txtTenKhachHang, cbPhimNhập tên khách hàng và chọn bộ phim để nạp bảng giá chuẩn.BookingFormcbPhongChieuTự động lọc danh sách phòng chiếu tương ứng với phim đã chọn.BookingFormpanelGhe (Matrix)Sơ đồ ghế tương tác: Xám (Trống), Xanh lá (Đang chọn), Đỏ (Đã khóa/Đã bán).BookingFormlblTinhTienTính tiền theo công thức hệ số: Vé biên = $25\\%$, Vé VIP = $200\\%$, Vé Thường = $100\\%$.BookingFormbtnThanhToanXuất hóa đơn lên rtbHoaDon, lưu vết vào input5.txt và cập nhật booked\_seats5.txt.PasswordFormtxtPasswordKhóa bảo mật quản trị (Mật khẩu truy cập: admin123).AdminFormbtnXuatThongKeĐọc input5.txt, dùng LINQ GroupBy theo Phim/Phòng, tính doanh thu, tỷ lệ lấp đầy (%) và thứ hạng.AdminFormbtnLuuXuất toàn bộ báo cáo doanh thu ra file output5.txt.🍜 Bai06 — Quản Lý Thực Đơn \& Gợi Ý Ngẫu Nhiên SQLiteChức năng: Quản lý danh sách món ăn, người đóng góp và quay số ngẫu nhiên chọn món bằng CSDL SQLite.Chi tiết trường \& Thao tác:Phân Hệ FormTrường ControlVai Trò \& Truy Vấn CSDLBai06lvDanhSachMonAnBảng hiển thị kết quả truy vấn SELECT m.IDMA, m.TenMonAn, n.HoVaTen FROM MonAn m LEFT JOIN NguoiDung n ON m.IDNCC = n.IDNCC.FormNhapLieutxtIDNCC, txtHoVaTen, cboQuyenHanNhập thông tin người đóng góp và lưu vào bảng NguoiDung.FormNhapLieutxtIDMA, txtTenMonAn, cboNguoiDongGop, btnChonAnhNhập thông tin món ăn, chọn file ảnh minh họa và lưu vào bảng MonAn.FormKetQualblTenMonAn, lblNguoiDongGop, picKetQuaHiển thị kết quả truy vấn ngẫu nhiên: SELECT ... ORDER BY RANDOM() LIMIT 1.📂 Bai07 — Trình Quản Lý Tệp \& Thư Mục (File Explorer)Chức năng: Duyệt cây thư mục hệ thống và xem trước nội dung hình ảnh.Chi tiết trường \& Thao tác:Trường Dữ Liệu / ControlLoại ControlChức năng \& Xử lý Kỹ thuậttvFolderBrowserTreeViewQuét ổ đĩa hệ thống. Áp dụng kỹ thuật Lazy Loading (dùng gút giả "dummy") chỉ tải thư mục con khi bấm mở rộng (BeforeExpand).picFileContentPictureBoxTự động xem trước ảnh khi người dùng nhấp chọn (AfterSelect) các file có đuôi .jpg, .png, .jpeg, .gif.⚡ 5. HƯỚNG DẪN CÀI ĐẶT \& KHỞI CHẠYClone Repository về máy cá nhân:Bashgit clone https://github.com/thanhnhi8769-ctrl/-NT106.R14-Lab02-25521332.git

Mở dự án với Visual Studio 2022:Mở Visual Studio 2022 (Phiên bản 17.0 trở lên).Chọn Open a project or solution.Chọn tệp giải pháp thế hệ mới Lab02.slnx.Biên dịch \& Khởi chạy (Build \& Run):Nhấn phím F5 hoặc chọn nút Start trên thanh công cụ để khởi chạy ứng dụng trung tâm DashBoard.

