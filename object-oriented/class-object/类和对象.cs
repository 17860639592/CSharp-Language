using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    /*
     * C#的类 包括方法 字段 和属性
     * 其中方法与Java的方法相同
     * 字段对应Java的属性
     * C#的属性是带有get set 访问器的字段
     */
    /*
     * C#的访问权限控制符:
            public：访问不受限制。
            protected：访问限于包含类或派生自包含类的类型。
            internal：访问限于当前程序集。
            protected internal：访问限于当前程序集或派生自包含类的类型。
            private：访问限于包含类型。
            private protected：访问限于包含类或派生自当前程序集中包含类的类型。
     */
    class Student
    {
        public Student(int id, string name, int score)//C#的构造器与Java的构造方法一致 不同的是 C#支持默认参数
        {
            Console.WriteLine("构造器被调用.");
            this.id = id;
            this.name = name;
            this.score = score;
        }
        public int id//这是一个属性 代表只读
        {
            private set;
            get;
        }
        private int score;//这是一个字段
        //以下是该字段的get set访问器
        public int getScore()
        {
            return this.score;
        }
        public void setScore(int score)
        {
            this.score = score;
        }
        public double score_percent//get和set可以根据需要展开
        {
            get
            {
                return (double)this.score / (double)100;
            }
            set
            {
                this.score = (int)value * 100;
            }
        }
        public string name
        {
            get;
            private set;
        }
        ~Student()//与Java不同的是 C#拥有像C++一样的析构器 可以在对象被销毁时做一些后处理 与C++不同的是 析构器不能被权限修饰符修饰
        {
            Console.WriteLine("析构器被调用.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(100, "aaa", 80);
            Console.WriteLine(string.Format("name: {0}, id: {1}, score: {2}, score_percent: {3}", s.name, s.id, s.getScore(), s.score_percent));
        }
    }
}
