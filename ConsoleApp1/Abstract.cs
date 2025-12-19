//using System;
//using System.Collections.Generic;
//using System.Text;

namespace ConsoleApp1
{
    class Abstract
    {
        public int EmpId;
        public string EName;
        public double EGrossPay;
        double TaxDeduction = 0.1;
        double Salary;

        public Abstract(int Eid, string Ename, double EgrossPay)
        {
            this.EmpId = Eid;
            this.EName = Ename;
            this.EGrossPay = EgrossPay;
            this.EGrossPay = EgrossPay;
        }

        void Calculator()
        {
            if (EGrossPay >= 30000)
            {
                Salary = EGrossPay - (TaxDeduction * EGrossPay);
                Console.WriteLine("U R Salary is: {0}", Salary);
            }
            else
            {
                Console.WriteLine("U R Salary is {0}", EGrossPay);
            }
        }
        public void Showsalary()
        {
            Console.WriteLine("Employee id is {0}", this.EmpId);
            Console.WriteLine("Employee Name is {0}", this.EName);
            Calculator();
        }
    }
    class Employee
    {
        static void Main(string[] args)
        {
            Abstract emp = new Abstract(102, "ketan", 25000);
            emp.Showsalary();   
            Console.ReadLine();
        }
    }
}
