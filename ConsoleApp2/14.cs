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
            int sum = 0;
            for(int i = 1; i <= 20; i++)
            {
                sum += i;
            }
            System.Console.WriteLine(sum);
        }
    }
}
