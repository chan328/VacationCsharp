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
            float inch;
            int cm;
            inch = float.Parse(Console.ReadLine());
            cm = Convert.ToInt32(inch / 2.54);
            System.Console.WriteLine(cm);
        }
    }
}
