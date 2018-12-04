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
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("aa");
            list.AddLast("bb");
            list.AddLast("cc");
            list.AddLast("dd");
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
    
}
