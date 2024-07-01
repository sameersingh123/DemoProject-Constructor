using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
     class ExplicitConstructorDemo
    {
        public ExplicitConstructorDemo()
        {
            Console.WriteLine("Explicit Constructor is called.");
        }
        public static void Main(string[] args)
        {
            ExplicitConstructorDemo obj1 = new ExplicitConstructorDemo();
            ExplicitConstructorDemo obj2 = new ExplicitConstructorDemo();
        }
    }
}
