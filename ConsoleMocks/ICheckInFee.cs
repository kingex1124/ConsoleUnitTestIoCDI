using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMocks
{
    public interface ICheckInFee
    {
        decimal GetFee(Customer customer);
    }
}
