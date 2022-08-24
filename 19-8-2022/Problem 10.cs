PROBLEM 10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Problem_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, reverse, sum = 0;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            for(int i = num; i!=0; i = i / 10)
            {
                reverse= i % 10;
                sum = sum * 10 + reverse;
            }
            Console.Write("The number in reverse order is : {0}", sum);
            Console.ReadLine();
        }
    }
}
