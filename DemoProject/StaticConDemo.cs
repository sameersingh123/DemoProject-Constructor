using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
     class StaticConDemo
    {
        static StaticConDemo()
        {
            Console.WriteLine("Static Constructor is called.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method is called.");
        }
    }
}
