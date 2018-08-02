using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class10
    {
        class TestClass : IBasic
        {
            public int TestPropertry {
                get => throw new NotImplementedException();
                set => throw new NotImplementedException();
            }

            public int TestInstanceMethod()
            {
                throw new NotImplementedException();
            }
        }
    }
    interface IBasic
    {
        int TestInstanceMethod();
        int TestPropertry { get; set; }
    }
}
