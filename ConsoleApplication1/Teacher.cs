using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// 老师类,继承Preson父类,收作业的接口
    /// </summary>
    class Teacher : Person, IHomeWork
    {
        /// <summary>
        /// 重写父类介绍自己的方法
        /// </summary>
        public override void AboutMe()
        {
            Console.WriteLine("我是老师");
        }
        /// <summary>
        /// 显式实现收作业的方法 
        /// </summary>
        void IHomeWork.DoHomeWork()
        {
            Console.WriteLine("老师收作业");
        }
    }
}
