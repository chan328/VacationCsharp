using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class9
    {
        class Product : IComparable
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public int CompareTo(object obj)
            {
                return this.Price.CompareTo((obj as Product).Price);
            }

            public override string ToString()
            {
                return Name + ":" + Price + "원";
            }
        }

        static void Main()
        {
            List<Product> list = new List<Product>
            {
                new Product() {Name = "고구마", Price = 2000},
                new Product() {Name="김치", Price = 9000},
                new Product() {Name="김치혁", Price = 0}
            };
            list.Sort();
            
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
