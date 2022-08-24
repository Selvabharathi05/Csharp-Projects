Problem 6


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter your age ");
            age=Convert.ToInt32(Console.ReadLine());
            if (age!=0)
            {
                Console.WriteLine("You look older than" +" "+ age);
                Console.ReadLine(); 

            }
        }
    }
}
