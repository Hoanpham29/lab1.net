using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class KhachHangVietNam : KhachHang
{
    public string LoaiKhachHang { get; set; }
    public int DinhMuc { get; set; }

    public KhachHangVietNam() { }

    public KhachHangVietNam(string maKH, int soLuong, double donGia, DateTime ngayHD, string hoTenKH, string loaiKH, int dinhMuc)
        : base(maKH, soLuong, donGia, ngayHD, hoTenKH)
    {
        LoaiKhachHang = loaiKH;
        DinhMuc = dinhMuc;
    }

    ~KhachHangVietNam() { }

    public new void Nhap(string maKH, int soLuong, double donGia, DateTime ngayHD, string hoTenKH, string loaiKH, int dinhMuc)
    {
        base.Nhap(maKH, soLuong, donGia, ngayHD, hoTenKH);
        LoaiKhachHang = loaiKH;
        DinhMuc = dinhMuc;
    }

    public new void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"Loai Khach Hang: {LoaiKhachHang}");
        Console.WriteLine($"Dinh Muc: {DinhMuc}");
    }
}

