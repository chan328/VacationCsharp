using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class11
    {
        static void Main()
        {
            //File.WriteAllText(@"c:\test\test.txt", "문자써버리기");
            Console.Write(File.ReadAllText(@"c:\test\test.txt"));
        }
    }
}
