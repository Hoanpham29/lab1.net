using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class KhachHangNuocNgoai : KhachHang
{
    public string QuocTich { get; set; }

    public KhachHangNuocNgoai() { }

    public KhachHangNuocNgoai(string maKH, int soLuong, double donGia, DateTime ngayHD, string hoTenKH, string quocTich)
        : base(maKH, soLuong, donGia, ngayHD, hoTenKH)
    {
        QuocTich = quocTich;
    }

    ~KhachHangNuocNgoai() { }

    public new void Nhap(string maKH, int soLuong, double donGia, DateTime ngayHD, string hoTenKH, string quocTich)
    {
        base.Nhap(maKH, soLuong, donGia, ngayHD, hoTenKH);
        QuocTich = quocTich;
    }

    public new void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"Quoc Tich: {QuocTich}");
    }
}


