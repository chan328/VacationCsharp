using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {
        static void Main()
        {
            Console.WriteLine(int.Parse("52"));
            Console.WriteLine(long.Parse("273"));
            Console.WriteLine(float.Parse("52.273"));
            Console.WriteLine(double.Parse("123.1"));
            Console.WriteLine();

            Console.WriteLine((52).ToString());
            Console.WriteLine(('a').ToString());
            Console.WriteLine((false).ToString());
        }
    }
}
