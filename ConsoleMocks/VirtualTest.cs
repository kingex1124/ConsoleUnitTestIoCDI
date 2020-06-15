using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMocks
{
    public class VirtualTest : AVirtualTest
    {
        public VirtualTest()
        {
           
        }
        public override string GetString()
        {
            return "Test";
        }
    }
}
