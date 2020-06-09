using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUnitTestIoCDI.New
{
    public class StubHash : IHash
    {
        public string GetHashResult(string password)
        {
            return "91";
        }
    }
}
