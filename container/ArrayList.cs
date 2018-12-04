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
            ArrayList arr = new ArrayList();
            arr.Add(10);
            arr.Add("11");
            arr.Add(12.11);
            arr.Add('a');
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
    
}
