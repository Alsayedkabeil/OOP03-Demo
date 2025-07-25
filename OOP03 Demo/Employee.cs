using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03_Demo
{
    internal class Employee:IComparable,ICloneable
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public object Clone()
        {
            return new Employee
            {
                Id = this.Id,
                Name = this.Name,
                Age = this.Age,
                Salary = this.Salary
            };
        } 

        public int CompareTo(object obj)
        {
            Employee e = obj as Employee;

            if (this.Age > e.Age) return 444;
            else if (this.Age < e.Age) return -444;
            else return 0;

        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}";
        }
    }
}
