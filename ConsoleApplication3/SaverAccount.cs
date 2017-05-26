using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class SaverAccount:IbankAccount
    {
        /// <summary>
        /// 账户名
        /// </summary>
        public string AccountName { get; set; }

   

        /// <summary>
        /// 无参的构造函数
        /// </summary>
        public SaverAccount()
        {

        }
        /// <summary>
        /// 设置账户名
        /// </summary>
        /// <param name="account">账户名</param>
        public SaverAccount(string accountName)
        {
            this.AccountName = accountName;
        }

        private decimal balance;
        /// <summary>
        /// 查看余额
        /// </summary>
        public decimal Balance
        {
            get
            {
                return balance;
            }
        }
        /// <summary>
        /// 存款
        /// </summary>
        /// <param name="amount">金额</param>
        public void PayIn(decimal amount)
        {
            balance = balance + amount;
        }
        /// <summary>
        /// 取款
        /// </summary>
        /// <param name="amount">金额</param>
        /// <returns>返回是否成功</returns>
        public bool PayOut(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine(AccountName+"取款成功,金额"+amount);
                return true;
            }
            Console.WriteLine("失败");
            return false;
        }
        /// <summary>
        /// 是否可以转账
        /// </summary>
        /// <param name="amount">金额</param>
        /// <returns>返回是否成功</returns>
        public bool PayTransfer(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("转账成功");
                return true;
            }
            Console.WriteLine("失败");
            return false;
        }
        /// <summary>
        /// 查看余额
        /// </summary>
        /// <returns>返回余额</returns>
        public override string ToString()
        {
            return string.Format("余额:{0,2:C}", balance);
        }
        /// <summary>
        /// 开户
        /// </summary>
        /// <returns>返回事件字符串</returns>
        public string OpenAccount()
        {
            return DateTime.Now.ToString("yyMMddhhmmss");
        }


        public bool TransferAccount(IbankAccount bankAccount, decimal amount)
        {
            if (PayOut(amount))
            {
                bankAccount.PayIn(amount);
                return true;
            }
            return false;
        }
    }
}
