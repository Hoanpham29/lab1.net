using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        ThemSinhVien(danhSachSinhVien, "Nguyen Van A", "Nam Dinh", 1999, 8.5);
        ThemSinhVien(danhSachSinhVien, "Tran Thi B", "Ha Noi", 2000, 9.0);
        ThemSinhVien(danhSachSinhVien, "Le Van C", "Nam Dinh", 2001, 7.5);

        Console.WriteLine("Danh sach sinh vien:");
        foreach (var sv in danhSachSinhVien)
        {
            sv.Xuat();
            Console.WriteLine();
        }
        SuaThongTinSinhVien(danhSachSinhVien, "Nguyen Van A", "Nguyen Van D", "Hai Phong", 1998, 8.7);

        XoaSinhVien(danhSachSinhVien, "Tran Thi B");

        Console.WriteLine("Sinh vien que o Nam Dinh:");
        var sinhVienNamDinh = danhSachSinhVien.Where(sv => sv.QueQuan == "Nam Dinh").ToList();
        foreach (var sv in sinhVienNamDinh)
        {
            sv.Xuat();
            Console.WriteLine();
        }

        Console.WriteLine("Sinh vien co diem tong ket cao nhat:");
        var diemTongKetCaoNhat = danhSachSinhVien.Max(sv => sv.DiemTongKet);
        var sinhVienDiemCaoNhat = danhSachSinhVien.Where(sv => sv.DiemTongKet == diemTongKetCaoNhat).ToList();
        foreach (var sv in sinhVienDiemCaoNhat)
        {
            sv.Xuat();
            Console.WriteLine();
        }
    }

    public static void ThemSinhVien(List<SinhVien> danhSach, string hoTen, string queQuan, int namSinh, double diemTongKet)
    {
        SinhVien sv = new SinhVien();
        sv.Nhap(hoTen, queQuan, namSinh, diemTongKet);
        danhSach.Add(sv);
    }

    public static void SuaThongTinSinhVien(List<SinhVien> danhSach, string hoTenCu, string hoTenMoi, string queQuanMoi, int namSinhMoi, double diemTongKetMoi)
    {
        var sv = danhSach.FirstOrDefault(s => s.HoTen == hoTenCu);
        if (sv != null)
        {
            sv.Nhap(hoTenMoi, queQuanMoi, namSinhMoi, diemTongKetMoi);
        }
    }

    public static void XoaSinhVien(List<SinhVien> danhSach, string hoTen)
    {
        var sv = danhSach.FirstOrDefault(s => s.HoTen == hoTen);
        if (sv != null)
        {
            danhSach.Remove(sv);
        }
    }
}
