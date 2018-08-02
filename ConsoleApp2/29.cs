using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
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
            public string producer;
            public string Editor;
            public string Designer;

            public PHP(string v1, int v2, string v3, string v4, string v5, string v6, string v7, string v8, string v9)
            {
                this.name = v1;
                this.publishDate = v2;
                this.outhor = v3;
                this.owner = v4;
                this.publisher = v5;
                this.editor = v6;
                this.producer = v7;
                this.Editor = v8;
                this.Designer = v9;
            }
        }
        static void Main()
        {
            PHP php = new PHP("PHP 프로그래밍 입문", 20130520, "황재호", "김태헌", "한빛아카데미(주)", "김현용", "김이화", "김이화", "여동일");
            
        }
    }
}
