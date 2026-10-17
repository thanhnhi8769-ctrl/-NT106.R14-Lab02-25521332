using Microsoft.Data.Sqlite;
using System;
using System.IO;

namespace HomNayAnGi
{
    public static class DatabaseHelper
    {
        public static string dbPath = "HomNayAnGi.db";
        // Chuỗi kết nối của Microsoft.Data.Sqlite chỉ cần Data Source
        public static string connectionString = $"Data Source={dbPath};";

        public static void InitializeDatabase()
        {
            // Kết nối tự động tạo file database nếu chưa tồn tại
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();

                // Tạo bảng NguoiDung
                string sqlNguoiDung = @"
                    CREATE TABLE IF NOT EXISTS NguoiDung (
                        IDNCC TEXT PRIMARY KEY,
                        HoVaTen TEXT NOT NULL,
                        QuyenHan TEXT
                    );";
                using (var cmd = new SqliteCommand(sqlNguoiDung, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                // Tạo bảng MonAn
                string sqlMonAn = @"
                    CREATE TABLE IF NOT EXISTS MonAn (
                        IDMA TEXT PRIMARY KEY,
                        TenMonAn TEXT NOT NULL,
                        HinhAnh TEXT,
                        IDNCC TEXT,
                        FOREIGN KEY (IDNCC) REFERENCES NguoiDung(IDNCC)
                    );";
                using (var cmd = new SqliteCommand(sqlMonAn, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}