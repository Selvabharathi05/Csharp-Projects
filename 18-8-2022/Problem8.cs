Problem 8


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the number");
            i=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", i);
            Console.WriteLine("{0}  {0}", i);
            Console.WriteLine("{0}  {0}", i);
            Console.WriteLine("{0}  {0}", i);
            Console.WriteLine("{0}{0}{0}", i);
            Console.ReadLine(); 
        }
    }
}
