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
    class Test
    {
        private Dictionary<int, int> dic = new Dictionary<int, int>();
        public int this[int index]//C#重载索引运算
        {
            get
            {
                return this.dic[index];
            }
            set
            {
                this.dic[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t[0] = 10;
            t[1] = 11;
            t[2] = 12;
            t[3] = 13;
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(t[i]);
            }
        }
    }
    
}
