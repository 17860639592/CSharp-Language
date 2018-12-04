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
            List<int> list = new List<int>();//List容器带有泛型
            list.Add(10);
            list.Add(12);
            list.Add(14);
            list.Add(15);
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
    
}
