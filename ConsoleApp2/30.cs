using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class2
    {
        class PHP
        {
            public string name;
            public int publishDate;
            public string outhor;
            public string owner;
            public string publisher;
            public string editor;
            public string producer;
            public string Editor;
            public string Designer;
            
        }
        static void Main()
        {
            PHP php = new PHP();
            php.name = "앙기모";
            Console.WriteLine(php.name);
        }
    }
}