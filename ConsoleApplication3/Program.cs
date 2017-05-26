using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            IbankAccount ba = new SaverAccount("焦康");
            string strNo = ba.OpenAccount();
            Console.WriteLine("一般储蓄银行卡号:" + strNo);
            ba.PayIn(1000);
            ba.PayOut(200);
            Console.WriteLine(ba.ToString());
            
            Console.WriteLine("——————————————");
            IbankAccount ga = new GoldAccount("李四");
            string strNo1 = ba.OpenAccount();
            Console.WriteLine("黄金储蓄银行卡号:" + strNo1);
            ga.PayIn(20000);
            ga.PayOut(100);
            Console.WriteLine(ga.ToString());
            
        

            #region 银行转账

            //IBankTransfer bt = new GoldAccount("李四");
            ga.TransferAccount(ba, 1000);//转账1000
            Console.WriteLine("转出方账户余额:");
            Console.WriteLine(ga.ToString());
            Console.WriteLine("转入方账户余额:");
            Console.WriteLine(ba.ToString());
            Console.ReadKey();
            #endregion

        }
    }
}
