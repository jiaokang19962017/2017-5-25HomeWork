using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    /// <summary>
    /// 鹦鹉类
    /// </summary>
    class YingWu : Bird, IFly
    {
        public override void AboutMe()
        {
            Console.WriteLine("我是鹦鹉");
        }

        void IFly.Fly()
        {
            Console.WriteLine("我可以飞");
        }
    }
}
