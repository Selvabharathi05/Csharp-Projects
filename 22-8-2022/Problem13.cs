Problem 13

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Problem_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = new int[] { 1, 3, 5, 200, 22, 2244, 213, 111 };
            Console.WriteLine("Numbers Greater than 100");
            for (int i = 0; i < myarray.Length; i++)
            {
                if (myarray[i]>100)
                {
                    Console.WriteLine(myarray[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
