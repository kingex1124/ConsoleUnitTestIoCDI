using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleMocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Mocks;
using ConsoleMocks.Model;

namespace ConsoleMocks.Tests
{
    [TestClass()]
    public class PubTests
    {
        [TestMethod]
        public void Test_Charge_Customer_Count()
        {
            //arrange
            ICheckInFee stubCheckInFee = MockRepository.GenerateStub<ICheckInFee>();
            Pub target = new Pub(stubCheckInFee);

            stubCheckInFee.Stub(x => x.GetFee(Arg<Customer>.Is.Anything)).Return(100);

            var customers = new List<Customer>
        {
            new Customer{ IsMale=true},
            new Customer{ IsMale=false},
            new Customer{ IsMale=false},
        };

            decimal expected = 1;

            //act
            var actual = target.CheckIn(customers);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Income()
        {
            //arrange
            ICheckInFee stubCheckInFee = MockRepository.GenerateStub<ICheckInFee>();
            Pub target = new Pub(stubCheckInFee);

            stubCheckInFee.Stub(x => x.GetFee(Arg<Customer>.Is.Anything)).Return(100);

            var customers = new List<Customer>
            {
                new Customer{ IsMale=true},
                new Customer{ IsMale=false},
                new Customer{ IsMale=false},
            };

            var inComeBeforeCheckIn = target.GetInCome();
            Assert.AreEqual(0, inComeBeforeCheckIn);

            decimal expectedIncome = 100;

            //act
            var chargeCustomerCount = target.CheckIn(customers);

            var actualIncome = target.GetInCome();

            //assert
            Assert.AreEqual(expectedIncome, actualIncome);
        }

        [TestMethod]
        public void Test_CheckIn_Charge_Only_Male()
        {
            //arrange mock
            var customers = new List<Customer>();

            //2男1女
            var customer1 = new Customer { IsMale = true };
            var customer2 = new Customer { IsMale = true };
            var customer3 = new Customer { IsMale = false };

            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            MockRepository mock = new MockRepository();
            ICheckInFee stubCheckInFee = mock.StrictMock<ICheckInFee>();

            using (mock.Record())
            {
                //期望呼叫ICheckInFee的GetFee()次數為2次
                stubCheckInFee.GetFee(customer1);

                LastCall
                    .IgnoreArguments()
                    .Return((decimal)100)
                    .Repeat.Times(2);
            }

            using (mock.Playback())
            {
                var target = new Pub(stubCheckInFee);

                var count = target.CheckIn(customers);
            }
        }

        [TestMethod]
        public void TestList()
        {
            //arrange
            ICheckInFee stubCheckInFee = MockRepository.GenerateStub<ICheckInFee>();

            CustomData c1 = new CustomData() { ID = 1, FirstName = "a", LastName = "B" };
            CustomData c2 = new CustomData() { ID = 2, FirstName = "x", LastName = "Y" };

            stubCheckInFee.Stub(o => o.GetList()).Return(new List<Model.CustomData>()
            {
                c1,c2
            });

            Pub target = new Pub(stubCheckInFee);

            var r = target.GetData();

            Assert.AreEqual(c1, r);
        }

        //可以同時mock 兩組
        [TestMethod]
        public void TestListByID()
        {
            //arrange
            ICheckInFee stubCheckInFee = MockRepository.GenerateStub<ICheckInFee>();

            CustomData c1 = new CustomData() { ID = 1, FirstName = "a", LastName = "B" };
            CustomData c2 = new CustomData() { ID = 2, FirstName = "x", LastName = "Y" };

            stubCheckInFee.Stub(o => o.GetList()).Return(new List<Model.CustomData>()
            {
                c1,c2
            });

            stubCheckInFee.Stub(o => o.GetListByID(Arg<int>.Is.Anything)).Return(new List<Model.CustomData>()
            {
                c1,c2
            });

            Pub target = new Pub(stubCheckInFee);
            // 下方這行為錯誤寫法 只有抽象類別 介面才可以Mock
            //target.Stub(o => o.GetData()).Return(c1);
            var r = target.GetDataByID(1);

            Assert.AreEqual(c1, r);

        }

        //abstract寫mock
        [TestMethod]
        public void TestGetString()
        {
            ICheckInFee stubCheckInFee = MockRepository.GenerateStub<ICheckInFee>();

            AVirtualTest avt = MockRepository.GenerateStub<AVirtualTest>();

            avt.Stub(o => o.GetString()).Return("abc");
            Pub target = new Pub(stubCheckInFee);

            var res = target.GetStr(avt);
        }
    }
}