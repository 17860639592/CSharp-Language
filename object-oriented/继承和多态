using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Base
    {
        public Base(int a, int c)
        {
            this.a = a;
            this.c = c;
        }
        public void set(int a)
        {
            this.a = a;
        }
        public int a
        {
            get;
            private set;
        }

        public virtual void setC(int c)
        {
            this.c = c;
        }
        public int c
        {
            get;
            private set;
        }
    }

    class Sub: Base//C#继承的写法类似与C++ 没有C++的权限控制符
    {
        public Sub(int a, int b, int c):base(a, c)//C#调用父类的构造函数使用base
        {
            this.b = b;
        }
        public void set(int a, int b)//C#可以对父类的普通方法进行覆盖
        {
            base.set(a);//调用父类的被覆盖方法
            this.b = b;
        }

        public override void setC(int c)//C#可以对父类的虚函数进行重写  父类的虚函数需要用virtual修饰 重写函数需要用override修饰
        {
            base.setC(c);//调用父类的虚函数
        }
        public int b
        {
            get;
            private set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Sub(10, 20, 30);//此处使用多态
            Console.WriteLine("a = " + b.a);
            Console.WriteLine("c = " + b.c);
            Console.WriteLine("b = " + (b as Sub).b);
            /*
             * is运算符 判断某个对象是否为某种数据类型
             * as运算符 把某个对象当作另一个对象使用
             */
        }
    }
}
