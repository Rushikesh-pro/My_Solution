using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Polymorphism
    {
        public void Add()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine(c);
        }
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        public void Add(string a, string b)
        {
            string c = a + " " + b;
            Console.WriteLine(c);
        }
        public void Add(float a, float b)
        {
            float c = a + b;
            Console.WriteLine(c);
        }
        public void Add(double a, double b)
        {
            double c = a + b;
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            Polymorphism pol = new Polymorphism();
            pol.Add();
            pol.Add(5, 9);
            pol.Add("Rushi", "Tushar");
            pol.Add(1f, 2f);
            pol.Add(1.2, 1.3);
            Console.ReadLine();
        }
    }
}
