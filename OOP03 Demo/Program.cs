namespace OOP03_Demo
{
    

    internal class Program
    {
        //static void PrintNumber(SeriesBy2 series)
        //{
        //    for (int i = 0; i < 20; i++)
        //    {
        //        Console.WriteLine($"{series.current}");
        //        series.Next();
        //    }
        //    series.Reset();
        //    Console.WriteLine();
        //}
        //static void PrintNumber(SeriesBy3 series)
        //{
        //    for (int i = 0; i < 20; i++)
        //    {
        //        Console.WriteLine($"{series.current}");
        //        series.Next();
        //    }
        //    series.Reset();
        //    Console.WriteLine();
        //}
        //static void PrintNumber( ISeries series)
        //{
        //    for (int i = 0; i < 20; i++)
        //    {
        //        Console.WriteLine($"{series.current}");
        //        series.Next();
        //    }
        //    series.Reset();
        //    Console.WriteLine();
        //}
        static void Main(string[] args)
        {
            #region V1 Revision

            /*class Vs  Struct
             * Inhertance :  
             * X .....> Y
             * Relationship between two classes
             * polymorphism
             
             
   
             */

            #endregion

            #region V2
            /*
             
             Interface : Reference Type
                *  Can not be instantiated
                * Code contract between the developer and the developer who will implement it
          
             */

            #endregion


            #region V3
            //MyType myType = new IMyType();
            //IMyType myType = new MyType();

            //myType.Salary = 1000.00;
            //Console.WriteLine(  myType.Salary);
            //myType.Print();
            //SeriesBy2 seriesBy2 = new SeriesBy2();


            //SeriesBy3 seriesBy3 = new SeriesBy3();
            //PrintNumber( seriesBy2);
            //PrintNumber (seriesBy3); 
            //SeriesBy3 seriesBy3 = new SeriesBy3();
            //PrintNumber(seriesBy3);

            //int[] Numbers = { 7, 6, 5, 4, 3, 2, 1, 8, 9 };

            //Array.Sort(Numbers); // Sort the array in ascending order

            //foreach (int item in Numbers)
            //{
            //    Console.Write($"{item} ");

            //  Employee[] employees = new Employee[3]
            //{
            //      new Employee { Id = 1, Name = "Ahmed", Age = 30, Salary = 12000 },
            //      new Employee { Id = 2, Name = "Omar", Age = 27, Salary = 11000 },
            //      new Employee { Id = 3, Name = "Amr", Age = 28, Salary = 13000 }
            //};

            //  Array.Sort(employees); // Sort by Salary
            //  foreach (Employee item in employees)
            //  {
            //      Console.WriteLine(item);

            #endregion

            #region V4
            //Car car = new Car();
            //car.Speed = 100;
            //car.Forward();

            //AirPlane airPlane = new AirPlane();


            //IMoveable moveable = airPlane;
            //moveable.Forward();
            //IFlayable flayable = airPlane;
            //flayable.Backward();
            #endregion

            #region V5

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //Console.WriteLine(value: $"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine(value: $"Arr02: {Arr02.GetHashCode()}");

            //Arr02 = (int[])Arr01.Clone(); // Deep Copy
            //                       // Clone Method Will Copy The Object State Of The Caller
            //                       // Assign The New Object to Arr02, Will Generate NEW Identity

            //Console.WriteLine(value: $"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine(value: $"Arr02: {Arr02.GetHashCode()}");

            // Identity (Address) + Object State [Data]

            //Arr02[0] = 100;

            //Console.WriteLine(Arr01[0]);
            #endregion

            #region V6
            //Employee E01 = new Employee { Id = 1, Name = "Ahmed", Age = 30, Salary = 12000 };
            //Employee E02 = new Employee { Id = 2, Name = "Omar", Age = 27, Salary = 11000 };
            //Employee E03 = new Employee { Id = 3, Name = "Amr", Age = 28, Salary = 13000 };
            //E01 = (Employee) E02.Clone(); // Reference Copy, Will Generate NEW Identity for E01
            //Console.WriteLine(  E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());
            #endregion

            #region V7
            //Employee[] employees = new Employee[3]
            //{
            //    new Employee { Id = 1, Name = "Ahmed", Age = 30, Salary = 12000 },
            //    new Employee { Id = 2, Name = "Omar", Age = 27, Salary = 11000 },
            //    new Employee { Id = 3, Name = "Amr", Age = 28, Salary = 13000 }
            //};
           /* Array.Sort(employees);*/ // Sort by Salary  

            //int result = employees[1].CompareTo(employees[2]);    
   ///hhhhhhhhhhhh
            #endregion
        }
        #region V 8

        //Array.Sort(employees,new EmployeeComparerSalary); 
        
        //    foreach (Employee item in employees)
        //    {
        //        Console.WriteLine(item);
        //    }
    #endregion




}

}
