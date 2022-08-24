Problem 11

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Enter The String ");
            s=Console.ReadLine();
            bool ans =string.IsNullOrEmpty(s);
            Console.WriteLine(ans);
            Console.ReadLine(); 


        }
    }
}
