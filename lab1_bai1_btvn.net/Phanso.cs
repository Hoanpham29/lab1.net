using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Phanso
{
    public int Tuso { get; set; }
    public int Mauso { get; set; }

    public Phanso()
    {
        Tuso = 0;
        Mauso = 1;
    }

    ~Phanso() { }

    public void Nhap(int tuso, int mauso)
    {
        Tuso = tuso;
        Mauso = mauso;
    }

    public void Xuat()
    {
        Console.WriteLine($"{Tuso}/{Mauso}");
    }
    public Phanso Cong(Phanso p)
    {
        Phanso result = new Phanso();
        result.Tuso = this.Tuso * p.Mauso + p.Tuso * this.Mauso;
        result.Mauso = this.Mauso * p.Mauso;
        return result;
    }
    public Phanso Tru(Phanso p)
    {
        Phanso result = new Phanso();
        result.Tuso = this.Tuso * p.Mauso - p.Tuso * this.Mauso;
        result.Mauso = this.Mauso * p.Mauso;
        return result;
    }
    public Phanso Nhan(Phanso p)
    {
        Phanso result = new Phanso();
        result.Tuso = this.Tuso * p.Tuso;
        result.Mauso = this.Mauso * p.Mauso;
        return result;
    }
    public Phanso Chia(Phanso p)
    {
        Phanso result = new Phanso();
        result.Tuso = this.Tuso * p.Mauso;
        result.Mauso = this.Mauso * p.Tuso;
        return result;
    }
}
