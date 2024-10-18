using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vemaybay
{
    public string TenChuyen { get; set; }
    public string NgayBay { get; set; }
    public double GiaVe { get; set; }

    public Vemaybay() { }

    public Vemaybay(string tenChuyen, string ngayBay, double giaVe)
    {
        TenChuyen = tenChuyen;
        NgayBay = ngayBay;
        GiaVe = giaVe;
    }

    ~Vemaybay() { }

    public void Nhap(string tenChuyen, string ngayBay, double giaVe)
    {
        TenChuyen = tenChuyen;
        NgayBay = ngayBay;
        GiaVe = giaVe;
    }

    public void Xuat()
    {
        Console.WriteLine($"Ten Chuyen: {TenChuyen}");
        Console.WriteLine($"Ngay Bay: {NgayBay}");
        Console.WriteLine($"Gia Ve: {GiaVe}");
    }

    public double GetGiaVe()
    {
        return GiaVe;
    }
}

