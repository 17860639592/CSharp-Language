using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    /*
     *  C#的类型转换和C语言基本一致
     *      小范围的类型向大范围转换可以隐式转换
     *      大范围的向小范围的可以显示转换
     */
    class Program
    {
        static void Main(string[] args)
        {
            //以下是一个显示转换的例子
            double d = 125.123;
            float f = (float)d;
            Console.WriteLine(f);
        }
    }
}
