Problem 3


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, sum=0;
            int[] myarray = new int[3];
            Console.Write("Input the number of elements to store in the array :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter {0} elements to store in the array  ", n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Element -{0} ", i);
                myarray[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var item in myarray)
            {
                sum += item;
            }
                Console.WriteLine("The sum of myarray is  \t:"+ sum);
                Console.ReadLine();
            
        }
    }
}
