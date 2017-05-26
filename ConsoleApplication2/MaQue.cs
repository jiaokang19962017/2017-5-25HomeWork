using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    /// <summary>
    /// 麻雀类
    /// </summary>
    class MaQue : Bird, IFly
    {
        /// <summary>
        /// 实现父类里的
        /// </summary>
        public override void AboutMe()
        {
            Console.WriteLine("我是麻雀");
        }

        /// <summary>
        /// 实现接口里面的方法
        /// </summary>
        void IFly.Fly()
        {
            Console.WriteLine("我可以飞");
        }
    }
}
