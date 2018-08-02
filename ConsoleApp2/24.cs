using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class2
    {
        static void Main()
        {
            MyMath myMath = new MyMath();
            Console.WriteLine(myMath.Abs(-1));
        }
        class MyMath
        {
            public double Abs(double x)
            {
                double y;
                if (x > -1)
                    y = x;
                else
                    y = -x;
                return y;
            }
            public int Abs(int x)
            {
                int y;
                if (x > -1)
                    y = x;
                else
                    y = -x;

                return y;
            }
            public int Abs(int x, int y)
            {
                int y1 = 0, y2 = 0;

                if (x > -1)
                    y1 = x;
                else
                    { y1 = -x; }

                if (y > -1)
                    y2 = y;
                else
                    y2 = -y;

                return y1;
            }
        }
    }
}
