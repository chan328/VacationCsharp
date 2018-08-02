using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {
        class Test
        {
            public int value = 10;
        }

        static void Change(Test input)
        {
            input.value = 20;
        }

        static void Main()
        {
            Test test = new Test();
            test.value = 10;
            Change(test);

            Console.WriteLine(test.value);
        }
    }
}
