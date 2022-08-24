PROBLEM 5


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Problem_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the First Number");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1>num2)
            {
                Console.WriteLine("First Number is Largest Number");
            }
            else
            {
                Console.WriteLine("Second Number is Largest Number");
            }
            Console.ReadLine();
        }
    }
}
