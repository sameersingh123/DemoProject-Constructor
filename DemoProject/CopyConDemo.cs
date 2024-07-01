using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
     class CopyConDemo
    {
        int x;
        public CopyConDemo(int i)
        {
            x = i;
        }
        public CopyConDemo(CopyConDemo obj)
        {
            x=obj.x;
        }
        public void Display()
        {
            Console.WriteLine(x);
        }
        static void Main()
        {
            CopyConDemo obj1 = new CopyConDemo(10);
            CopyConDemo obj2 = new CopyConDemo(obj1);
            obj1.Display();
            obj2.Display();
        }
    }
}
