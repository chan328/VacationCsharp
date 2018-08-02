using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class13
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader(@"c:\test\test.txt"))
            {
                string line = reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
