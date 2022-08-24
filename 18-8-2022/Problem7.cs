Problem 7



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the number");
            i=Convert.ToInt32(Console.ReadLine());
            Console.Write(i);
            Console.Write(" ");
            Console.Write(i);
            Console.Write(" ");
            Console.Write(i);
            Console.Write(" ");
            Console.Write(i);
            Console.WriteLine();

            Console.Write(i);
            Console.Write(i);
            Console.Write(i);
            Console.Write(i);
            Console.WriteLine();

            Console.WriteLine("{0} {0} {0} {0}", i);
            Console.WriteLine("{0}{0}{0}{0}", i);
            Console.ReadLine(); 
        }
    }
}
