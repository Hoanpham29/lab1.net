using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Nguoi
{
    public string HoTen { get; set; }
    public string GioiTinh { get; set; }
    public int Tuoi { get; set; }

    public Nguoi() { }

    public Nguoi(string hoTen, string gioiTinh, int tuoi)
    {
        HoTen = hoTen;
        GioiTinh = gioiTinh;
        Tuoi = tuoi;
    }

    ~Nguoi() { }

    public void Nhap(string hoTen, string gioiTinh, int tuoi)
    {
        HoTen = hoTen;
        GioiTinh = gioiTinh;
        Tuoi = tuoi;
    }

    public void Xuat()
    {
        Console.WriteLine($"Ho Ten: {HoTen}");
        Console.WriteLine($"Gioi Tinh: {GioiTinh}");
        Console.WriteLine($"Tuoi: {Tuoi}");
    }
}

