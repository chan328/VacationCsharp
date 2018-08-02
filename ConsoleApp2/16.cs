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
            string[] Array = {"사과", "김치", "김지", "김지혁"};

            foreach(var food in Array)
            {
                Console.WriteLine(food);
            }
        }
    }
}
