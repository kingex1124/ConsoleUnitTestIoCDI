using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUnitTestIoCDI.New
{
    public class Validation
    {
        private IAccountDao _accountDao;
        private IHash _hash;

        public Validation(IAccountDao dao, IHash hash)
        {
            this._accountDao = dao;
            this._hash = hash;
        }

        public bool CheckAuthentication(string id, string password)
        {
            // 取得資料中，id對應的密碼                       
            var passwordByDao = this._accountDao.GetPassword(id);

            // 針對傳入的password，進行hash運算
            var hashResult = this._hash.GetHashResult(password);

            // 比對hash後的密碼，與資料中的密碼是否吻合
            return passwordByDao == hashResult;
        }
    }
}
