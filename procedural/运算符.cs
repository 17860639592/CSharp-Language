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
         * C#的运算符与Java一模一样
         */
        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine((double)a / (double)b);
            Console.WriteLine(a % b);
        }
    }
}
