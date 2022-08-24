PROBLEM 9

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Problem_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  n, sum = 0;
            

            Console.WriteLine("Enter the number of terms :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The odd numbers are :");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine( 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.WriteLine("The Sum of odd Natural Number upto {0} terms : {1} ", n, sum);
            Console.ReadLine();
        }
    }
}
        
    
