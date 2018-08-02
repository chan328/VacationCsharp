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
            int a1 = 2147483640;
            int b1 = 52273;
            Console.WriteLine(a1 + b1);
            Console.WriteLine();

            uint uint1 = 4147483647;
            ulong ulong1 = 11223372036854775808;
            Console.WriteLine(uint1);
            Console.WriteLine(ulong1);
            Console.WriteLine();

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine();

            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine();
        }
    }
}
