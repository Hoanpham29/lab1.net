using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class TestProgram
{
    public static void Main()
    {
        Phanso obj1 = new Phanso();
        Phanso obj2 = new Phanso();

        obj1.Nhap(3, 4);
        obj2.Nhap(2, 5); 

        Phanso tong = obj1.Cong(obj2);
        Phanso hieu = obj1.Tru(obj2);
        Phanso tich = obj1.Nhan(obj2);
        Phanso thuong = obj1.Chia(obj2);

        Console.WriteLine("Phan so 1: ");
        obj1.Xuat();
        Console.WriteLine("Phan so 2: ");
        obj2.Xuat();

        Console.WriteLine("Tong: ");
        tong.Xuat();
        Console.WriteLine("Hieu: ");
        hieu.Xuat();
        Console.WriteLine("Tich: ");
        tich.Xuat();
        Console.WriteLine("Thuong: ");
        thuong.Xuat();
    }
}