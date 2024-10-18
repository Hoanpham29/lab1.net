using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        List<Hanhkhach> danhSachHanhKhach = new List<Hanhkhach>();

        Vemaybay ve1 = new Vemaybay("VN123", "2024-10-20", 150.0);
        Vemaybay ve2 = new Vemaybay("VN456", "2024-10-25", 200.0);
        Vemaybay ve3 = new Vemaybay("VN789", "2024-10-30", 300.0);

        Vemaybay[] veArray1 = { ve1, ve2 };
        Vemaybay[] veArray2 = { ve2, ve3 };
        Vemaybay[] veArray3 = { ve1, ve3 };

        danhSachHanhKhach.Add(new Hanhkhach("Nguyen Van A", "Nam", 30, veArray1, veArray1.Length));
        danhSachHanhKhach.Add(new Hanhkhach("Tran Thi B", "Nu", 25, veArray2, veArray2.Length));
        danhSachHanhKhach.Add(new Hanhkhach("Le Van C", "Nam", 28, veArray3, veArray3.Length));

        Console.WriteLine("Danh sach hanh khach va tong tien:");
        foreach (var hk in danhSachHanhKhach)
        {
            hk.Xuat();
            Console.WriteLine($"Tong Tien: {hk.TongTien()}");
            Console.WriteLine();
        }

        danhSachHanhKhach.Sort((a, b) => b.TongTien().CompareTo(a.TongTien()));

        Console.WriteLine("Danh sach hanh khach (da sap xep theo tong tien giam dan):");
        foreach (var hk in danhSachHanhKhach)
        {
            hk.Xuat();
            Console.WriteLine($"Tong Tien: {hk.TongTien()}");
            Console.WriteLine();
        }
    }
}

