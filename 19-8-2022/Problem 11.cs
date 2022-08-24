PROBLEM 11

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Problem_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 100; i <=200; i++)
            {
                if (i % 9 == 0)
                {
                    Console.Write("{0} ", i);
                    sum += i;
                }
               
            }
            Console.WriteLine("\nSum of numbers which is divisible by 9 in 100 to 200 :  {0} ", sum);
            Console.ReadLine();

        }
    }
}
