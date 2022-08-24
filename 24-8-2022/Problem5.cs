Problem 5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReusableCodeLibrary;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string s1 = Console.ReadLine();
            uppercase.Upper(s1);
            Console.ReadLine();
        }
    }
}
==================================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class uppercase
    {
        public static void Upper(string s)
        {
            string s2 = s.ToUpper();
            Console.WriteLine("Converted to "+ s2);
        }
    }
}
