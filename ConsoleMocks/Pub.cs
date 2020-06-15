using ConsoleMocks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMocks
{
    public class Pub
    {
        private ICheckInFee _checkInFee;
        private decimal _inCome = 0;

        public Pub(ICheckInFee checkInFee)
        {
            this._checkInFee = checkInFee;
        }

        /// <summary>
        /// 入場
        /// </summary>
        /// <param name="customers"></param>
        /// <returns>收費的人數</returns>
        public int CheckIn(List<Customer> customers)
        {
            var result = 0;

            foreach (var customer in customers)
            {
                var isFemale = !customer.IsMale;

                //女生免費入場
                if (isFemale)
                {
                    continue;
                }
                else
                {
                    //for stub, validate status: income value
                    //for mock, validate only male
                    this._inCome += this._checkInFee.GetFee(customer);

                    result++;
                }

                //for fake

                //var isLadyNight = DateTime.Today.DayOfWeek == DayOfWeek.Friday;

                //禮拜五女生免費入場
                //if (isLadyNight && isFemale)
                //{
                //    continue;
                //}
                //else
                //{
                //    //for stub, validate status: income value
                //    //for mock, validate only male
                //    this._inCome += this._checkInFee.GetFee(customer);

                //    result++;
                //}
            }

            //for stub, validate return value
            return result;
        }

        public decimal GetInCome()
        {
            return this._inCome;
        }

        public CustomData GetData()
        {

            int count = _checkInFee.GetList().Where(o => o.ID == 1).Count();
            //return _checkInFee.GetList().First();
            //return _checkInFee.GetList().Where(o => o.ID == 1).First();
            return _checkInFee.GetList().Find(o => o.ID == 1);
        }

        public CustomData GetDataByID(int id)
        {

            int count = _checkInFee.GetList().Where(o => o.ID == 1).Count();
            //return _checkInFee.GetList().First();
            //return _checkInFee.GetList().Where(o => o.ID == 1).First();
            return _checkInFee.GetListByID(id).First();
        }
    }
}
