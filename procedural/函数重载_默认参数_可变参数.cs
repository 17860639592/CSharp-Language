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
         * C#的方法重载, 默认参数, 可变参数
         * C#的方法重载和默认参数和C++一致
         * C#的可变参数类似于Python
         */
        public static void print(string str = "")//默认参数必须放在后面
        {
            Console.WriteLine(str);
        }
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }
        public static int sum(params int[] list)
        {
            int ret = 0;
            foreach (int i in list)
            {
                ret += i;
            }
            return ret;
        }
        static void Main(string[] args)
        {
            print("Hello World !");
            Console.WriteLine(add(10, 20));
            Console.WriteLine(add(10, 20, 30));
            Console.WriteLine(sum(10, 20, 30, 40));
        }
    }
}
