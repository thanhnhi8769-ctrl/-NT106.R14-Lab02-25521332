using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Lab02
{
    internal static class Program
    {
        /// <summary>
        /// Điểm bắt đầu chính của ứng dụng.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 1. Khởi tạo cấu hình DPI chống mờ
            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            // 2. Khởi tạo cấu hình giao diện mặc định
            ApplicationConfiguration.Initialize();

            // 3. Khởi chạy Form1 (Luôn đặt ở DÒNG CUỐI CÙNG của hàm Main)
            Application.Run(new DashBoard());
        }
    }
}