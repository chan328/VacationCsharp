using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {
        public static void Main()
        {
            int num;
            Random ran = new Random();
            int Correct = ran.Next(1, 200);
            while(true)
            {
                num = int.Parse(Console.ReadLine());
                if (num > Correct)
                    Console.WriteLine($"{num}보다는 작은 숫자입니당");
                else if (num < Correct)
                    Console.WriteLine($"{num}보다는 큰 숫자입니당");
                else if (num == Correct)
                {
                    Console.WriteLine("정답!!");
                    break;
                }
            }
        }
    }
}
