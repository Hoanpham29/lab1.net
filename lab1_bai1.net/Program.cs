using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Csharp
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            //để chế độ output là UTF-8 
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // chỉnh màu nền 
            Console.BackgroundColor = ConsoleColor.White;
            //Xóa màu nên cũ 
            Console.Clear();
            // chỉnh màu chữ  
            Console.ForegroundColor = ConsoleColor.Black;
            SinhVien sv1 = new SinhVien("0001", "Đinh Thị Mỹ Anh","Hà Tĩnh", 11);
            sv1.HienThi();
            Console.WriteLine("--------------------------");
            SinhVienIT sv2 = new SinhVienIT();
            sv2.Ma = "102";
            sv2.HoTen = "Trần Thị Hồng Ngọc";
            sv2.QueQuan = "Hà Nam";
            sv2.Khoa = 8;
            sv2.HienThi();
            Console.WriteLine("-------------------------");
            SinhVien sv3 = new SinhVienIT();
            sv3.Ma = "115";
            sv3.HoTen = "Lê Thị Thanh Trà";
            sv3.QueQuan = "Hà Nam";
            sv3.Khoa = 8;
            sv3.HienThi();
            Console.WriteLine("--------------------------");
            SinhVien sv4 = new SinhVienIT();
            sv4.Ma = "116";
            sv4.HoTen = "Phạm Thanh Thiên";
            sv4.QueQuan = "Hải Dương";
            sv4.Khoa = 8;
            sv4.HienThi();
            Console.ReadKey();
        }
    }
}