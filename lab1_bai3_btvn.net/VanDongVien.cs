﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class VanDongVien
{
    public string HoTen { get; set; }
    public int Tuoi { get; set; }
    public string MonThiDau { get; set; }
    public double CanNang { get; set; }
    public double ChieuCao { get; set; }

    public VanDongVien() { }

    public VanDongVien(string hoTen, int tuoi, string monThiDau, double canNang, double chieuCao)
    {
        HoTen = hoTen;
        Tuoi = tuoi;
        MonThiDau = monThiDau;
        CanNang = canNang;
        ChieuCao = chieuCao;
    }

    ~VanDongVien() { }

    public void HienThi()
    {
        Console.WriteLine($"Ho Ten: {HoTen}");
        Console.WriteLine($"Tuoi: {Tuoi}");
        Console.WriteLine($"Mon Thi Dau: {MonThiDau}");
        Console.WriteLine($"Can Nang: {CanNang}");
        Console.WriteLine($"Chieu Cao: {ChieuCao}");
    }
}

