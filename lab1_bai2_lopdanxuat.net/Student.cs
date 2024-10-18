using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Csharp
{
    class Student : Person
    {
        public void ThongBaoTuoi()
        {
            Console.WriteLine("Tuoi cua ban la: {0} tuoi", age);
        }
    }
}