using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    /*
     * partial修饰的类叫做分布类
     * 所有相同名称处于同一命名空间的类本质上是一个类
     */
    partial class Stu
    {
        public Stu(int id, string name, int score)
        {
            this.id = id;
            this.name = name;
            this.score = score;
        }
        public override string ToString()
        {
            return string.Format("name: {0}, id: {1}, score: {2}", this.name, this.id, this.score);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stu s = new Stu(10, "aa", 80);
            Console.WriteLine(s);
        }
    }
    partial class Stu
    {
        public int id
        {
            get;
            private set;
        }
        public string name
        {
            get;
            private set;
        }

        public int score
        {
            get;
            private set;
        }
    }
}
