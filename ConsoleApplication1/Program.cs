using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person stu = new Student();//实例化对象
            stu.AboutMe();//调用介绍自己的方法
            IHomeWork stu1 = new Student();//通过接口实例化对象
            stu1.DoHomeWork();//调用收作业方法

            Person t = new Teacher();
            t.AboutMe();
            IHomeWork t1 = new Teacher();
            t1.DoHomeWork();

            Person p = new Principal();
            p.AboutMe();
            
        }
    }
}
