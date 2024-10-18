using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Csharp
{
    class SinhVienIT : SinhVien
    {
        public new void HienThi()
        {
            Console.WriteLine("Sinh Vien IT");
            base.HienThi();
        }
    }
}