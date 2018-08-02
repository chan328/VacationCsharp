using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class7
    {
        class Program
        {
            static void Main()
            {
                string RawString;
                using (WebClient clinet = new WebClient())
                {
                    clinet.Encoding = Encoding.UTF8;
                    RawString = clinet.DownloadString(@"http://dsm2015.cafe24.com/v2/meal/2018-08-01");
                }

                //Console.WriteLine(RawString);

                var All = JToken.Parse(RawString);
                Console.WriteLine(RawString);
                //Console.WriteLine(All.GetType());

                var AllObject = All as JObject;
                foreach(var food in AllObject)
                {
                    Console.WriteLine(food);
                    Console.WriteLine(food.GetType());
                }
                Console.WriteLine(AllObject.GetType());
                foreach(var temp in AllObject.Children())
                {
                    var temp2 = temp as JProperty;
                    Console.WriteLine("<" + temp2.Path + ">");
                    //Console.WriteLine(temp2.Path);
                    //Console.WriteLine(temp2.Value);
                    //Console.WriteLine(temp2.Value.GetType());

                    var temp2Toarray = temp2.Value as JArray;
                    foreach(var temp3 in temp2Toarray)
                    {
                        Console.WriteLine(temp3);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
