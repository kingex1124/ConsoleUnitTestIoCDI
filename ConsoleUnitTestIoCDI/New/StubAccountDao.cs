using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUnitTestIoCDI.New
{
    public class StubAccountDao : IAccountDao
    {
        public string GetPassword(string id)
        {
            return "91";
        }
    }
}
