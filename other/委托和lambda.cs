using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    delegate int MyDelegate(int a, int b);//定义委托类型 (相当于C++的 typedef int( *MyDelegate)(int a, int b);)
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate add = (int a, int b) => { return a + b; };//定义委托变量 并用lambda表达式初始化
            Console.WriteLine(add(10, 20));
            MyDelegate sub = (a, b) => a + b;//lambda的化简形式
            Console.WriteLine(sub(20, 5));
        }
    }
    
}
