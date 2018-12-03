using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        /*
         * C#的方法定义
         *      [修饰符]返回值 函数名(形参列表)
         *      {
         *          函数体;
         *          返回值
         *      }
         *      关于ref和out
         *      ref要求传递的参数是一个变量 并且已经初始化
         *      out值要求传递的参数是一个变量
         */
        public static void swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine(string.Format("a = {0}, b = {1}", a, b));
            swap(ref a, ref b);
            Console.WriteLine(string.Format("a = {0}, b = {1}", a, b));
        }
    }
}
