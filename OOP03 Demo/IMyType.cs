using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03_Demo
{
    internal interface IMyType
    {
        // 1. Signature Of Properties
        double Salary { get; set; }

        // 2. Signature Of Methods [Name, Parameter, Return Type]
        void MyFun();

        // 3. Default Implemented Methods [Fully Implemented Methods]
        void Print()
        {
            Console.WriteLine("Default Implemented Methods [Fully Implemented Methods]");

        }
    }
}
