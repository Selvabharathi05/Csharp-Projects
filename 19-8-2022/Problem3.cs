PROBLEM 3


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c1, c2;
            Console.WriteLine("Enter the First Character");
            c1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the Second Character");
            c2 = Convert.ToChar(Console.ReadLine());
            bool ans =c1.Equals(c2);
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
