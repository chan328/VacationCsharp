using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class2
    {
        public class Student
        {
            public string name;
            public int grade;
        }

        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student() { name = "강찬", grade = 1 });
            list.Add(new Student() { name = "김지혁", grade = 2 });
            list.Add(new Student() { name = "김모지", grade = 3 });
            list.Add(new Student() { name = "김윤재", grade = 4 });
            list.Add(new Student() { name = "안뇽이", grade = 5 });
            list.Add(new Student() { name = "웅늉이", grade = 6 });

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].grade > 1)
                {
                    list.Remove(list[i]);
                }
            }

            foreach (var std in list)
            {
                Console.WriteLine(std.name + "" + std.grade);   
            }
        }
    }
}
