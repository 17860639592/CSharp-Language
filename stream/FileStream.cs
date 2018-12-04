using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "./Hello.txt";
            if (File.Exists(path))
                File.Delete(path);
            FileStream fs = File.Open(path, FileMode.Create);
            fs.Seek(0, SeekOrigin.End);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.Write("Hello World !");
            sw.Flush();
            sw.Close();
            StreamReader sr = new StreamReader(File.Open(path, FileMode.Open), Encoding.Default);
            string str = sr.ReadLine();
            Console.WriteLine(str);
            sr.Close();
            //二进制读写使用以下两个方法
            //BinaryReader
            //BinaryWriter
        }
    }
    
}
