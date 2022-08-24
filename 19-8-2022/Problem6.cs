PROBLEM 6


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Problem_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter the Year");
            year = Convert.ToInt32(Console.ReadLine());
            if ((year%4)==0)
            {
                Console.WriteLine("Entered year is Leap year");
            }
            else
            {
                Console.WriteLine("Not a Leap year");
            }
            Console.ReadLine();
        }
    }
}
