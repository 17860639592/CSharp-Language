//可以使用using指令来导入指定命名空间
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Demo是一个命名空间
namespace Demo
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //可以通过这样使用其他命名空间的类 枚举等
            Test.Demo d = new Test.Demo("aaa");
            Console.WriteLine(d.str);
        }
    }
    
}
//Test也是一个命名空间
namespace Test
{
    class Demo
    {
        public Demo(string str)
        {
            this.str = str;
        }
        public string str
        {
            get;
            private set;
        }
    }
}
