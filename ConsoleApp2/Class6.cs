using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class6
    {
        class Animal
        {
            public virtual void Eat()
            {
                Console.WriteLine("ㄴㄴ");
            }
        }

        class Dog : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("개사료ㄴㄴ");
            }
        }
        class Cat : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("냥사료 ㄴㄴ");
            }
        }

        static void Main()
        {
            List<Animal> list = new List<Animal>()
            {
                new Dog(), new Cat(), new Dog(), new Cat(),
                new Cat(), new Dog(), new Cat(), new Dog()
            };

            foreach(var item in list)
            {
                item.Eat();
            }
        }
    }
}
