using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUnitTestIoCDI.New
{
    public class AccountDao : IAccountDao
    {
        public string GetPassword(string id)
        {
            throw new NotImplementedException();
        }
    }
}
