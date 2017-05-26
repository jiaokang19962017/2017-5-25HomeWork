using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    interface IbankAccount:IbankTransfer
    {
        /// <summary>
        /// 存款方法
        /// </summary>
        /// <param name="amount">金额</param>
        void PayIn(decimal amount);
        /// <summary>
        /// 取款
        /// </summary>
        /// <param name="amount">金额</param>
        /// <returns>存款成功返回true</returns>
        bool PayOut(decimal amount);
        /// <summary>
        /// 余额
        /// </summary>
        decimal Balance
        {
            get;
        }
        /// <summary>
        /// 开户方法
        /// </summary>
        /// <returns>返回银行卡号</returns>
        string OpenAccount();
    }
}
