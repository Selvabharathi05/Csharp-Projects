PROBLEM 2


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the First Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("First Number is the Largest Number");
                }
                else
                {
                    Console.WriteLine("Third Number is the Largest Number");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("Second Number is the Largest Number");
            } 
            else
                Console.WriteLine("Third Number is the Largest Number");
            Console.ReadLine();
        }
      
    }
}
