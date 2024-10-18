using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<KhachHang> danhSachKhachHang = new List<KhachHang>();

        KhachHangNuocNgoai kh1 = new KhachHangNuocNgoai("KH001", 100, 1500, new DateTime(2020, 9, 15), "John Doe", "USA");
        KhachHangVietNam kh2 = new KhachHangVietNam("KH002", 200, 1200, new DateTime(2020, 9, 20), "Nguyen Van A", "Sinh Hoat", 50);
        KhachHangNuocNgoai kh3 = new KhachHangNuocNgoai("KH003", 150, 1400, new DateTime(2020, 10, 10), "Jane Smith", "UK");

        danhSachKhachHang.Add(kh1);
        danhSachKhachHang.Add(kh2);
        danhSachKhachHang.Add(kh3);

        Console.WriteLine("Danh sach khach hang:");
        foreach (var kh in danhSachKhachHang)
        {
            kh.Xuat();
            Console.WriteLine();
        }

        var tongSoLuongVietNam = danhSachKhachHang.OfType<KhachHangVietNam>().Sum(kh => kh.SoLuong);
        var tongSoLuongNuocNgoai = danhSachKhachHang.OfType<KhachHangNuocNgoai>().Sum(kh => kh.SoLuong);

        Console.WriteLine($"Tong so luong dien tieu thu cua khach hang Viet Nam: {tongSoLuongVietNam}");
        Console.WriteLine($"Tong so luong dien tieu thu cua khach hang nuoc ngoai: {tongSoLuongNuocNgoai}");

        var khachHangNuocNgoai = danhSachKhachHang.OfType<KhachHangNuocNgoai>();
        var trungBinhThanhTienNuocNgoai = khach