using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03_Demo
{
    internal interface ISeries
    {
        // Signature of the property
       public int current{ get; set; }
        // Signature of the method
        void Next();

        // Default implemented method
        void Reset();
      
    
    }
}
