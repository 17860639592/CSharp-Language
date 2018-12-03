using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    /*
     * 关于抽象类和接口 与Java基本 一致
     * C#不同与C++ 和Java一样只支持单继承 一旦继承了一个类(包括普通类和抽象类) 都不可以继承其他的类
     */
    abstract class Add
    {
        abstract public int add(int a, int b);//抽象类含有抽象方法 也可以含有普通方法 这点和Java一致
    }
    interface Sub
    {
        int sub(int a, int b);//接口的方法不可以进行修饰
    }
    //与Java不同的是 C#实现接口和实现类的方法一致
    //C# 要求如果 一个类同时继承一个类 并实现其他接口时  继承的类必须放在最前面

    class Cac : Add, Sub
    {
        public override int add(int a, int b)
        {
            return a + b;
        }

        public int sub(int a, int b)
        {
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sub sub = new Cac();
            Add add = (sub as Cac);
            //C#的接口和抽象类同样可以实现多态
            Console.WriteLine(sub.sub(10, 5));
            Console.WriteLine(add.add(10, 5));
        }
    }
    
}
