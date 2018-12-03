using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    /*
     *  C#的所有数据类型都是对象
     *  C#的数据类型包括 int float double string...等 与其他语言类似
     */
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            Console.WriteLine("简单相加程序");
            Console.Write("输入第一个数:");
            s1 = Console.ReadLine();
            Console.Write("输入第二个数:");
            s2 = Console.ReadLine();
            Console.WriteLine(string.Format("两个数相加的和为:{0}", int.Parse(s1) + int.Parse(s2)));
        }
    }
}
