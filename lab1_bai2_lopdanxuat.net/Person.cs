using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Csharp
{
    class Person
    {
        protected int age;
        public void LoiChao()
        {
            Console.WriteLine("Hello"); 
        }
        public void SetAge(int n)
        {
            age = n;
        }
    }
}