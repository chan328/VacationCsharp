using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {
            static int power(int input)
            {
                input = input * input;
                return input;
            }
            static int power(int input, int count)
            {
                for (int i = 1; i < count; i++)
                    input = input * input;
                return input;
            }
            static int sumAll(int end)
            {
                int sum = 0;
                for (int i = 0; i <= end; i++)
                    sum += i;
                return sum;
            }
            static int sumAll(int start, int end)
            {
                int sum = 0;
                for (int i = start; i <= end; i++)
                    sum += i;
                return sum;
            }
            static void Main()
            {
                Console.WriteLine(power(3));
                Console.WriteLine(power(2, 2));
                Console.WriteLine(sumAll(4));
                Console.WriteLine(sumAll(1, 4));
            }
        
        }
    }

