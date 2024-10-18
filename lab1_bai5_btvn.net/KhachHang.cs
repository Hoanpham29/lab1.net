using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class KhachHang
{
    public string MaKhachHang { get; set; }
    public int SoLuong { get; set; }
    public double DonGia { get; set; }
    public double ThanhTien { get { return SoLuong * DonGia; } }
    public DateTime NgayHoaDon { get; set; }
    public string HoTenKhachHang { get; set; }

    public KhachHang() { }

    public KhachHang(string maKH, int soLuong, double donGia, DateTime ngayHD, string hoTenKH)
    {
        MaKhachHang = maKH;
        SoLuong = soLuong;
        DonGia = donGia;
        NgayHoaDon = ngayHD;
        HoTenKhachHang = hoTenKH;
    }

    ~KhachHang() { }

    public void Nhap(string maKH, int soLuong, double donGia, DateTime ngayHD, string hoTenKH)
    {
        MaKhachHang = maKH;
        SoLuong = soLuong;
        DonGia = donGia;
        NgayHoaDon = ngayHD;
        HoTenKhachHang = hoTenKH;
    }

    public void Xuat()
    {
        Console.WriteLine($"Ma Khach Hang: {MaKhachHang}");
        Console.WriteLine($"So Luong: {SoLuong}");
        Console.WriteLine($"Don Gia: {DonGia}");
        Console.WriteLine($"Thanh Tien: {ThanhTien}");
        Console.WriteLine($"Ngay Hoa Don: {NgayHoaDon.ToShortDateString()}");
        Console.WriteLine($"Ho Ten Khach Hang: {HoTenKhachHang}");
    }
}


