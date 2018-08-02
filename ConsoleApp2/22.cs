using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class2
    {
        class Sum
        {
            public int Summ(int x, int y)
            {
                int summ = 0;
                for(int i = x; i <= y; i++)
                {
                    summ += i;
                }
                return summ;
            }
        }

        static void Main()
        {
            Sum sum = new Sum();
            Console.WriteLine(sum.Summ(1, 100));
        }
    }
}
