using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03_Demo
{
    internal class MyType : IMyType// Implementing the IMyType interface
    {
        public double Salary { get; set; }
        public void MyFun()
        {
            Console.WriteLine("MyFun Method Is Called");
        }
        // Overriding the default implemented method
        public void Print()
        {
            Console.WriteLine("Overridden Print Method in MyType Class");
        }
    }
}
