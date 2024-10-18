using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Csharp
{
    public class TestProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Class trong C#");
            Console.WriteLine("------------------------\n");
            Box Box1 = new Box();   // tao doi tuong Box1 
            Box Box2 = new Box();   // tao doi tuong Box2 
            double the_tich = 0.0;  // the tich cua box 
                                    // thong tin cua box1 
            Box1.chieu_cao = 5.0;
            Box1.chieu_dai = 6.0;
            Box1.chieu_rong = 7.0;
            // thong tin cua box2 
            Box2.chieu_cao = 10.0;
            Box2.chieu_dai = 12.0;
            Box2.chieu_rong = 13.0;
            // Tinh va in the tich cua box1 
            the_tich = Box1.chieu_cao * Box1.chieu_dai * Box1.chieu_rong;
            Console.WriteLine("The tich cua Box1 la: {0}", the_tich);
            // Tinh va in the tich cua box2 
            the_tich = Box2.chieu_cao * Box2.chieu_dai * Box2.chieu_rong;
            Console.WriteLine("The tich cua Box2 la: {0}", the_tich);
            Console.ReadKey();
        }
    }
}