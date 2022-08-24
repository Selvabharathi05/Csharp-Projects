Problem 4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, l,m;
            Console.WriteLine("Enter the First Number");
            i=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fourth Number");
            l = Convert.ToInt32(Console.ReadLine());
            m= (i+j+k+l)/4;
            Console.WriteLine("Average is" +" "+ m);
            Console.ReadLine();


        }
    }
}
