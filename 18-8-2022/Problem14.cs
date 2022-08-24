Problem 14

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount, rupee;
            Console.WriteLine("Enter the amount ");
            amount=Convert.ToInt32(Console.ReadLine());
            rupee = amount * 80;
            Console.WriteLine("Indian Rupees"+" " + rupee);
            Console.ReadLine(); 
        }
    }
}
