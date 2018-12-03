using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    /*
     * C#要求 一个类如果被sealed修饰 那么该类不能被继承 类似与Java的final
     */
    sealed class Person
    {
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public int age
        {
            get;
            private set;
        }
        public string name
        {
            get;
            private set;
        }
        public override string ToString()
        {
            return string.Format("name: {0}, age: {1}", this.name, this.age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("aaa", 20);
            Console.WriteLine(p);
        }
    }
    
}
