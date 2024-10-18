using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SinhVien
{
    public string HoTen { get; set; }
    public string QueQuan { get; set; }
    public int NamSinh { get; set; }
    public double DiemTongKet { get; set; }
    public SinhVien() { }
    ~SinhVien() { }

    public void Nhap(string hoTen, string queQuan, int namSinh, double diemTongKet)
    {
        HoTen = hoTen;
        QueQuan = queQuan;
        NamSinh = namSinh;
        DiemTongKet = diemTongKet;
    }
    public void Xuat()
    {
        Console.WriteLine("Ho Ten: " + HoTen);
        Console.WriteLine("Que Quan: " + QueQuan);
        Console.WriteLine("Nam Sinh: " + NamSinh);
        Console.WriteLine("Diem Tong Ket: " + DiemTongKet);
    }
}
