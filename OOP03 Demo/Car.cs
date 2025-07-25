using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03_Demo
{
    internal class Car : IMoveable, IFlayable
    {
        public int Speed { get; set; }
        public void Forward()
        {
            Console.WriteLine("Car is moving forward.");
        }
        public void Backward()
        {
            Console.WriteLine("Car is moving backward.");
        }
        public void Left()
        {
            Console.WriteLine("Car is turning left.");
        }
        public void Right()
        {
            Console.WriteLine("Car is turning right.");
        }
        
    }
}
