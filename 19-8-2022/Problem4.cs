PROBLEM 4


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            Console.WriteLine("Enter the First String");
            s1= Console.ReadLine();
            Console.WriteLine("Enter the Second String");
            s2 = Console.ReadLine();
            if (s1==s2)
            {
                Console.WriteLine("Strings Are Equal");
            }
            else
            {
                Console.WriteLine("Strings are Not Equal");
            }
            Console.ReadLine();  
        }
    }
}
