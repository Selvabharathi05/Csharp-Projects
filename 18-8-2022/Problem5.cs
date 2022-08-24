
Problem 5


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x,y, z,a,b;
            Console.WriteLine("Enter the First Number");
            x= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number");
            z = Convert.ToInt32(Console.ReadLine());
            a = (x + y) * z;
            b =(x*y) + (y*z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();

        }
    }
}
