Problem 5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Problem_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] class_jag =new int[4][];
            class_jag[0] = new int[] { 5, 9, 6 };
            class_jag[1] = new int[] { 15, 19, 16,4 };
            class_jag[2] = new int[] { 21, 9 };
            class_jag[3] = new int[] { 5, 9, 6,3,1 };
            for (int i = 0; i < class_jag.Length; i++)
            {
                Console.WriteLine("Class {0}:",i);
                for (int j = 0; j < class_jag[i].Length; j++)
                {
                    Console.WriteLine("{0}" ,class_jag[i][j]);
                }
            }
            Console.ReadLine();


        }
    }
}
