using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class SinhVien
{
    public string Ma { get; set; }
    public string HoTen { get; set; }
    public string QueQuan { get; set; }
    public int Khoa { get; set; }

    public void HienThi()
    {
        Console.WriteLine("Ma: " + Ma);
        Console.WriteLine("Ho Ten: " + HoTen);
        Console.WriteLine("Que Quan: " + QueQuan);
        Console.WriteLine("Khoa: " + Khoa);
    }

    public void TrangThai()
    {
        if (Khoa < 11)
        {
            Console.WriteLine("Da tot nghiep");
        }
        else
        {
            Console.WriteLine("Chua tot nghiep");
        }
    }
}
