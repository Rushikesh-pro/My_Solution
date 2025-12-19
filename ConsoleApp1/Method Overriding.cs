using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    namespace overiding
    {
        class parent
        {
            public virtual void print()
            {
                Console.WriteLine("Access");
            }
        }
        class child : parent
        {
            public override void print()
            {
                //base.print();
                Console.WriteLine("Non-Access");
            }
        }
        class over
        {
            static void Main(string[] args)
            {
                parent p = new child();
                //child c = new child();
                p.print();
                //c.print();
            }
        }
    }
}
