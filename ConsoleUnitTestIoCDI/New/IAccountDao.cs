using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUnitTestIoCDI.New
{
    public interface IAccountDao
    {
        string GetPassword(string id);
    }
}
