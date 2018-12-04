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
    [Serializable]//可以序列化的类不能被继承
    class Person
    {
        public Person(string name, int age, string sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public string name
        {
            get;
            private set;
        }
        public int age
        {
            get;
            private set;
        }
        [NonSerialized]//表示指定字段不能被序列化  只能修饰字段
        public string sex;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("aaa", 20, "男");
            FileStream fs = File.Open("./class.dat", FileMode.OpenOrCreate);
            fs.Seek(0, SeekOrigin.End);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, p);
            p = null;
            fs.Seek(0, SeekOrigin.Begin);
            p = bf.Deserialize(fs) as Person;
            Console.WriteLine(p.name);
            Console.WriteLine(p.age);
            Console.WriteLine(p.sex);
        }
    }
    
}
