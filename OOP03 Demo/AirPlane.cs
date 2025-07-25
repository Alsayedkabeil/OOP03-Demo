using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03_Demo
{
    internal class AirPlane :IFlayable,IMoveable
    {
        int IMoveable.Speed { get; set; }
      
        void IMoveable.Forward()
        {
            Console.WriteLine("plane is moving forward.");
        }
           void IMoveable.Backward()
        {
            Console.WriteLine("plane is moving backward.");
        }
         void IMoveable.Left()
        {
            Console.WriteLine("plane is turning left.");
        }
         void IMoveable.Right()
        {
            Console.WriteLine("plane is turning right.");
        }



        int IFlayable.Speed{ get; set; }
        void IFlayable.Forward()
        {
            Console.WriteLine("plane is moving forward.");
        }
         void IFlayable.Backward()
        {
            Console.WriteLine("plane is moving backward.");
        }
        void IFlayable.Left()
        {
            Console.WriteLine("plane is turning left.");
        }
        void IFlayable.Right()
        {
            Console.WriteLine("plane is turning right.");
        }
    }
}
