using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Hanhkhach : Nguoi
{
    public Vemaybay[] Ve { get; set; }
    public int SoLuong { get; set; }

    public Hanhkhach() { }

    public Hanhkhach(string hoTen, string gioiTinh, int tuoi, Vemaybay[] ve, int soLuong)
        : base(hoTen, gioiTinh, tuoi)
    {
        Ve = ve;
        SoLuong = soLuong;
    }

    ~Hanhkhach() { }

    public void Nhap(string hoTen, string gioiTinh, int tuoi, Vemaybay[] ve, int soLuong)
    {
        base.Nhap(hoTen, gioiTinh, tuoi);
        Ve = ve;
        SoLuong = soLuong;
    }

    public new void Xuat()
    {
        base.Xuat();
        for (int i = 0; i < SoLuong; i++)
        {
            Console.WriteLine($"Ve {i + 1}:");
            Ve[i].Xuat();
        }
    }

    public double TongTien()
    {
        double tongTien = 0;
        for (int i = 0; i < SoLuong; i++)
        {
            tongTien += Ve[i].GetGiaVe();
        }
        return tongTien;
    }
}

