using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class4
    {
        class Parent
        {
            public int Var = 273;
            public void Method()
            {

            }
        }

        class Child : Parent
        {
            public new string Var = "String";
            public new void Method()
            {
                Console.WriteLine("자식의 메서드");

                
            }
        }
            static void Main()

            {
                    Child child = new Child();
                    child.Method();
                    ((Parent) child).Method();
            }
    }
}
