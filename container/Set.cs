using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HashSet");
            HashSet<int> hs = new HashSet<int>();//基于散列表实现
            hs.Add(10);
            hs.Add(20);
            hs.Add(30);
            hs.Add(40);
            foreach(var i in hs)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("SortedSet");
            SortedSet<int> ss = new SortedSet<int>();//基于红黑树实现
            ss.Add(80);
            ss.Add(70);
            ss.Add(60);
            ss.Add(50);
            foreach(var i in ss)
            {
                Console.WriteLine(i);
            }
        }
    }
    
}
