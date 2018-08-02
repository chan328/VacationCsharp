using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Animal
    {
        public int Age { get; set; }

        public Animal() { this.Age = 0;  }

        public void Eat() { Console.WriteLine("냠냠"); }
        public void Sleep() { Console.WriteLine("zzz"); }
    }
    class Dog : Animal
    {
        //public int Age { get; set; } // 속성을 사용하면 안정됨
        public string Color { get; set; }

        public Dog() { this.Age = 0;  }

        //public void Eat() { Console.WriteLine("냠냠 먹습니당");}
        //public void Sleep() { Console.WriteLine("쿨쿨 잡니당"); }
        public void Bark() { Console.WriteLine("멍멍!"); }

        static void Main()
        {
            List<Animal> animals = new List<Animal>()
            {
                new Cat(), new Cat(), new Cat(),
                new Dog(), new Dog(), new Dog()
            };
            foreach(var item in animals)
            {
                //item.Eat();
                //item.Sleep();

                //if (item is Dog)
                //    Console.WriteLine("멈뭄미");
                //if (item is Cat)
                //   Console.WriteLine("냠몸미");
                var dog = item as Dog;
                if (dog != null) { dog.Bark(); }
                var cat = item as Cat;
                if (cat!=null) { cat.Eat(); } // as는 클래스 자료형을 변환시킴.
            }
        }
    }
    class Cat : Animal
    {
        //public int Age { get; set; }
        public string Color { get; set; }

        public Cat() { this.Age = 0; }

        //public void Eat() { Console.WriteLine("냠냠 먹어용"); }
        //public void Sleep() { Console.WriteLine("쿨쿨 자용"); }
        public void Bark() { Console.WriteLine("야옹!"); }
    }
}
