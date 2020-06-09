using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUnitTestIoCDI.Old
{
    public class Validation
    {
        public bool CheckAuthentication(string id, string password)
        {
            // 取得資料中，id對應的密碼           
            AccountDao dao = new AccountDao();
            var passwordByDao = dao.GetPassword(id);

            // 針對傳入的password，進行hash運算
            Hash hash = new Hash();
            var hashResult = hash.GetHashResult(password);

            // 比對hash後的密碼，與資料中的密碼是否吻合
            return passwordByDao == hashResult;
        }
    }
}
