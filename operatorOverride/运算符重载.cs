using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Demo
{
    class Point
    {
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int x;
        public int y;
        /*
         * C#运算符重载必须声明为静态函数
         * 
         * C#运算符可重载情况
            +, -, !, ~, ++, --	这些一元运算符只有一个操作数，且可以被重载。
            +, -, *, /, %	这些二元运算符带有两个操作数，且可以被重载。
            ==, !=, <, >, <=, >=	这些比较运算符可以被重载。
            &&, ||	这些条件逻辑运算符不能被直接重载。
            +=, -=, *=, /=, %=	这些赋值运算符不能被重载。
            =, ., ?:, ->, new, is, sizeof, typeof	这些运算符不能被重载。
         */
        public static Point operator+(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 20);
            Point p2 = new Point(15, 15);
            Point p3 = p1 + p2;
            Console.WriteLine(p3.x + ", " + p3.y);
        }
    }
    
}
