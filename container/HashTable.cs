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
            Hashtable ht = new Hashtable();
            ht.Add(1, "a");
            ht.Add(2, "b");
            ht.Add(3, "c");
            ht.Add(4, "d");
            ht.Add(5, "e");
            foreach(var i in ht.Keys)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            foreach(var i in ht.Values)
            {
                Console.WriteLine(i);
            }
        }
    }
    
}
