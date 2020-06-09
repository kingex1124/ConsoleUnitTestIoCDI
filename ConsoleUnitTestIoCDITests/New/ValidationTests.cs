using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleUnitTestIoCDI.New;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUnitTestIoCDI.New.Tests
{
    [TestClass()]
    public class ValidationTests
    {
        [TestMethod()]
        public void ValidationTest()
        {
            //arrange
            // 初始化StubAccountDao，來當作IAccountDao的執行個體
            IAccountDao dao = new StubAccountDao();

            //初始化StubHash，來當作IHash的執行個體
            IHash hash = new StubHash();

            // 將自訂的兩個stub object，注入到目標物件中，也就是Validation物件
            Validation target = new Validation(dao, hash);

            string id = "id隨便啦";
            string password = "密碼也沒關係";

            // 期望為true，因為預期hash後的結果是"91"，而IAccountDao回來的結果也是"91"，所以為true
            bool expected = true;

            //act
            bool actual;
            actual = target.CheckAuthentication(id, password);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckAuthenticationTest()
        {
            Assert.Fail();
        }
    }
}