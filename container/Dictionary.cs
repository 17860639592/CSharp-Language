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
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic[0] = "aa";
            dic[1] = "bb";
            dic[2] = "cc";
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(dic[i]);
            }
        }
    }
    
}
