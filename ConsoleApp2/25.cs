using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class3
    {
        class Product
        {
            public int id;
            public string name;
            public int price;
            public static int count = 0;

            public Product(int id, string name, int price)
            {
                this.id = id;
                this.name = name;
                this.price = price;
                Product.count++;
            }
        }

        static void Main()
        {
            Product[] products = { new Product(1, "potato", 90000), new Product(2, "sweetpotato", 10) };
            for(int i = 0; i <= 1; i++)
            {
                Console.WriteLine(products[i].id +":"+ products[i].name +":"+ products[i].price);
            }
            Console.WriteLine(Product.count + "개 만들어졌습니다.");
        }
    }
}
