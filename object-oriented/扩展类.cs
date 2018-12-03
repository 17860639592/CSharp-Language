using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    /*
     * 使用扩展方法必须使用静态类
     * 扩展方法必须使用静态函数 而且静态函数只能通过对象来访问
     * 扩展方法的形参格式为 this + 类名 + 形参名
     */


    //以下是为系统的string类写的扩展方法的样例
    public static class ExtendString
    {
        public static int toInt(this string str)
        {
            return int.Parse(str);
        }
        public static double toDouble(this string str)
        {
            return double.Parse(str);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "123";
            string str2 = "123.456";
            Console.WriteLine(str1.toInt());
            Console.WriteLine(str2.toDouble());
        }
    }
    
}
