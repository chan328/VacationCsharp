using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Parent
    {
        public static int number = 10;
        public int Var = 273;

        public void Method()
        {
            Console.WriteLine("부모의 메서드");
        }

        static void Main()
        {
            int number = 20;
            Console.WriteLine(number);
            Console.WriteLine();

            child childA = new child();
            Console.WriteLine(childA.Var);

            child childB = new child();
            Console.WriteLine(((Parent)childB).Var);

            child childC = new child();
            childC.Method();
            ((Parent)childC).Method();
        }
    }

    class child : Parent
    {
        public new string Var = "Shadowing";
        public new void Method()
        {
            Console.WriteLine("자식의 메서드");
        }
    }

}
