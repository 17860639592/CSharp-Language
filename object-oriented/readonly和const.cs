using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        /* const 默认是静态的
         * readonly 只有在显示声名是静态的才会是静态的
         * const 可以修饰局部变量 而readonly不行
         */
        const int a = 10;
        static readonly int b = 20;
        static void Main(string[] args)
        {
            const int c = 30;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
