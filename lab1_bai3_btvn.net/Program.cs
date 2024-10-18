using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        VanDongVien p = new VanDongVien("Nguyen Van A", 25, "Chay 100m", 70.5, 1.75);
        Console.WriteLine("Thong tin cua p:");
        p.HienThi();
        Console.WriteLine();

        List<VanDongVien> danhSachVanDongVien = new List<VanDongVien>
        {
            new VanDongVien("Tran Thi B", 22, "Boi", 55.3, 1.60),
            new VanDongVien("Le Van C", 27, "Nhay xa", 65.2, 1.80),
            new VanDongVien("Pham Thi D", 24, "Da bong", 60.0, 1.70)
        };

        Console.WriteLine("Danh sach van dong vien:");
        foreach (var vdv in danhSachVanDongVien)
        {
            vdv.HienThi();
            Console.WriteLine();
        }

        danhSachVanDongVien.Sort((a, b) => a.Tuoi.CompareTo(b.Tuoi));

        Console.WriteLine("Danh sach van dong vien (da sap xep theo tuoi tang dan):");
        foreach (var vdv in danhSachVanDongVien)
        {
            vdv.HienThi();
            Console.WriteLine();
        }
    }
}
