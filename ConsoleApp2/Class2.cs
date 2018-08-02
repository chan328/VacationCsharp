using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class2
    {
        class Parent
        {
            public int Var = 273;
        }

        class child : Parent
        {
            public string var = "Shadowing";
        }

        static void Main()
        {
            child child = new child();
            Console.WriteLine(child.var);
        }
    }
}
