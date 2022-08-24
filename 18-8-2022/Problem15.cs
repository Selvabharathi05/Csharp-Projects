Problem 15

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter the first Integer");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Integer");
            y = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("True");

            }
            else
            {
                Console.WriteLine("False");
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
