using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        /*
         * C#的一维数组与其他语言一致
         * C#的多维数组与其他语言有些不同
         * 以二维数组为例
         * 可以是数组的数组
         * 也可以是直接的二维数组
         */
        static void Main(string[] args)
        {
            int[][] arr1 = new int[5][];
            for(int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = new int[5];
            }
            //arr1为数组的数组

            int[,] arr2 = new int[5, 5];
            //arr2为直接的二维数组
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    arr1[i][j] = i * 5 + j;
                    arr2[i, j] = i * 5 + j;
                }
            }
            Console.WriteLine("arr1的遍历结果: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr1[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("arr2的遍历结果: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
