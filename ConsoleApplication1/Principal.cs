using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// 校长类,继承Person类
    /// </summary>
    class Principal : Person
    {
        /// <summary>
        /// 重写介绍自己的父类方法
        /// </summary>
        public override void AboutMe()
        {
            Console.WriteLine("我是校长");
        }
    }
}
