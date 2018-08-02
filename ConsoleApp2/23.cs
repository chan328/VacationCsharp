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
            MyMath myMath = new MyMath();
            Console.WriteLine(myMath.Abs(-1));
        }
        class MyMath
        {
            public int Abs(int x)
            {
                int y;
                if (x > -1)
                    y = x;
                else
                    y = -x;

                return y;
            }
        }
    }
}
