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
         * C#的流程控制语句
         * if else
         * switch case
         * while for do-while
         * 与Java一模一样
         */
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            if(s1 == s2)
                Console.WriteLine("s1 == s2");
            else
                Console.WriteLine("s1 != s2");
            /*
             * 其余控制语句不再演示
             */
        }
    }
}
