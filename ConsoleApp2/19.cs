using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {
        static public void Main(string[] args)
        {
            List<string> list = new List<string>(); // <, > == generic : 클래스 선언 시 어떤 자료형인지 알려주는 것.

            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");

            foreach(var num in list)
            {
                Console.WriteLine(num);
            }
        }
    }
}
