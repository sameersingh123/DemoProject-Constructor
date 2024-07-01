using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
     class ParameterizedConDemo
    {
        int x;
        public ParameterizedConDemo(int i)
        {
            x = i;
            Console.WriteLine("Paramerterized Constructor is called "+i);
        }
        public void Display()
        {
            Console.WriteLine("Value of x is "+x);
        }
        
        static void Main(string[] args)
        {
            ParameterizedConDemo obj1 = new ParameterizedConDemo(10);
            ParameterizedConDemo obj2 = new ParameterizedConDemo(20);

            obj1.Display();
            obj2.Display();
        }
    }
}
