using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    /// <summary>
    /// 鸵鸟类
    /// </summary>
    class TuoNiao : Bird
    {
        public override void AboutMe()
        {
            Console.WriteLine("我是鸵鸟");
        }
    }
}
