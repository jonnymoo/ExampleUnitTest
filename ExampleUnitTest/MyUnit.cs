using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleUnitTest
{
    public class MyUnit
    {
        private IThingyAble thingy;

        public MyUnit(IThingyAble thingy)
        {
            this.thingy = thingy;
        }

        public int DoSomething(int i)
        {
            return i + 1;
        }

        public void DoSomethingWhichCallsIntoThingy()
        {
            thingy.DoThingy("Whatsit");
        }
    }
}
