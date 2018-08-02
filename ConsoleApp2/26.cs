using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Box
    {
        public Box(int width, int height)
            {
            Width = width;
            Height = height;
            }
         private int width;
         public int Width
        {
            get { return Width;  }
            set
            {
                if (value > 0) { width = value; }
                else { Console.WriteLine("자연수를 입력하세요"); }
            }
        }
        private int height;
        public int Height
        {
            get { return height;  }
            set
            {
                if(value > 0) { width = value; }
                else { Console.WriteLine("자연수를 입력하세여"); }
            }
        }
        public int Area() { return this.height * this.width; }

        static void Main()
        {
            Box box = new Box(-10, -20);

            box.Width = -200;
            box.Height = -100;
        }
    }
}
