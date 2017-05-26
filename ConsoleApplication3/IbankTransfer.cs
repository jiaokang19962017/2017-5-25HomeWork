using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    interface IbankTransfer
    {
        /// <summary>
        /// 转账方法
        /// </summary>
        /// <param name="bankAccount">账户名</param>
        /// <param name="amount">金额</param>
        /// <returns>转账成功返回true</returns>
        bool TransferAccount(IbankAccount bankAccount, decimal amount);



       
    }
}
