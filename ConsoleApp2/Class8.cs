using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class8
    {
        class Wanted<t>
        {
            public t value;
            public Wanted(t value)
            {
                this.value = value;
            }
        }

        class Program
        {
            static void Main()
            {
                Wanted<string> wantedString = new Wanted<string>("String");
                Wanted<int> wantedInt = new Wanted<int>(52273);
                Wanted<double> wantedDouble = new Wanted<double>(52.273);


                Console.WriteLine(wantedString.value);
                Console.WriteLine(wantedInt.value);
                Console.WriteLine(wantedDouble.value);
            }
        }

    }
}
