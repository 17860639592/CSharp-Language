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
    /*
     * C#的异常与Java一致
     * 包括自定义异常也是 
     * 此处不多说明
     */
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new NullReferenceException();
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Data);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Data);
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }
    }
    
}
