using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
     class ConstructorsDemo
    {
        int x;
        static int y;
        static ConstructorsDemo()
        {
            Console.WriteLine("Static Constructor is called.");
        }
        public ConstructorsDemo()
        {
            Console.WriteLine("Non-static Constructor is called.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main method is called");
            ConstructorsDemo obj1 = new ConstructorsDemo();
            Console.WriteLine(y);
            Console.WriteLine(obj1.x);


        }
    }
}
