Problem 16


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            Console.WriteLine("Enter the firstname");
            s1=Console.ReadLine();
            Console.WriteLine("Enter the Lastname");
            s2 = Console.ReadLine();
            if (!string.IsNullOrEmpty(s1) && !string.IsNullOrEmpty(s2))
            {
                Console.WriteLine("Welcome to my App");
            }
            else
            {
                Console.WriteLine("Please login");
            }
            Console.ReadLine(); 
        }
    }
}
