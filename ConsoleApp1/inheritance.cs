using System;
using System.Collections.Generic;
using System.Text;


// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

namespace inheritance
{

    class Visting : Employee
    {
        public int VistingEmployee;
        public int permenantEmployee;
    }
    class permenant : Employee
    {
        public int VistingEmployee;
        public int permenantEmployee;
    }
    class Employee
    {
        public int EmpID;
        public string Name;
        public string Designation;
    }
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            permenant emp = new permenant();
            emp.EmpID = 12;

            Visting ing = new Visting();
            ing.EmpID = 14;

            Console.WriteLine(emp.EmpID);
            Console.WriteLine(ing.EmpID);
            Console.ReadLine();
        }
    }
}