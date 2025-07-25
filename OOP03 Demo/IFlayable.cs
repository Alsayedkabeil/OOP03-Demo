using OOP03_Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03_Demo
{
    internal interface IFlayable
    {
        
        
            int Speed { get; set; }
            void Forward();
            void Backward();
            void Left();
            void Right();
        
    }
}
