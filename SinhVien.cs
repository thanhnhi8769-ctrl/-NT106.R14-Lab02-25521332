using System;
using System.Text.Json.Serialization;

[Serializable]
public class SinhVien
{
    public string HoTen { get; set; }
    public int MSSV { get; set; }
    public string DienThoai { get; set; }
    public float DiemMon1 { get; set; }
    public float DiemMon2 { get; set; }
    public float DiemMon3 { get; set; }
    public float DiemTB { get; set; }

    public SinhVien() { }

    public SinhVien(string hoTen, int mssv, string dienThoai, float d1, float d2, float d3)
    {
        HoTen = hoTen;
        MSSV = mssv;
        DienThoai = dienThoai;
        DiemMon1 = d1;
        DiemMon2 = d2;
        DiemMon3 = d3;
        DiemTB = 0;
    }

    public void TinhDiemTB()
    {
        DiemTB = (float)Math.Round((DiemMon1 + DiemMon2 + DiemMon3) / 3.0f, 2);
    }
}