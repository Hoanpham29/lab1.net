using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Csharp
{
    class TestProgram
    {
        static void Main()
        {
            bool debug = false;
            Console.WriteLine("\nLap trinh huong doi tuong trong C#");
            Console.WriteLine("-------------------------------\n");
            Person myPerson = new Person();
            myPerson.LoiChao();
            Student myStudent = new Student();
            myStudent.SetAge(21);
            myStudent.LoiChao();
            myStudent.ThongBaoTuoi();
            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(30);
            myTeacher.LoiChao();
            myTeacher.GiangDay();
            if (debug)
                Console.ReadLine();
            Console.ReadKey();
        }
    }
}
