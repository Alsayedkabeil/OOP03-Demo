using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03_Demo
{
    internal class SeriesBy3 : ISeries
    {
        public int current { get; set; } = 0;
        public void Next()
        {
            current += 3;
            Console.WriteLine($"Current value is now: {current}");
        }
        public void Reset()
        {
            current = 0;

        }  
              
}   }

