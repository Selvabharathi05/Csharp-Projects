Problem 13

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int celsius,fahrenheit;
            Console.WriteLine("Enter the celcius");
            celsius=Convert.ToInt32(Console.ReadLine());
            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("fahrenheit" +" " +fahrenheit);
            Console.ReadLine(); 
        }
    }
}
