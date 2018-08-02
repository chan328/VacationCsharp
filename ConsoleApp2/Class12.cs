using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class12
    {
        static void Main()
        {
            using (StreamWriter write = new StreamWriter(@"c:\test\test.txt"))
            {
                write.WriteLine("안뇽하세연");
                write.WriteLine("streamWriter 클래스를 사용해");
                write.WriteLine("글자를 여러 줄 출력해 봅니당");

                for(int i = 0; i < 10; i++)
                {
                    write.WriteLine("반복문 - " + i);
                }
            }
            Console.WriteLine(File.ReadAllText(@"c:\test\test.txt"));
        }
    }
}
