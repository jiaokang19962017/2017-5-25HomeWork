using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// 学生类,继承Person父类,收作业接口
    /// </summary>
    class Student : Person, IHomeWork
    {
        /// <summary>
        /// 重写父类介绍自己的方法
        /// </summary>
        public override void AboutMe()
        {
            Console.WriteLine("我是学生");
        }
        /// <summary>
        ///显式 实现收作业的方法
        /// </summary>
        void IHomeWork.DoHomeWork()
        {
            Console.WriteLine("学生收作业");
        }
    }
}
