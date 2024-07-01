using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
     class TestClass
    {
        int x;
        public TestClass(int x)
        {
            this.x = x;
        }
        static void Main()
        {
            TestClass obj1 = new TestClass(10);
            Console.WriteLine(obj1.x);

            TestClass obj2 = new TestClass(20);
            Console.WriteLine(obj2.x);
           
        }
    }
}
