Problem 12


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, num1, kilometre,metre;
            Console.WriteLine("Enter the value of metres");
            num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of Kilometres");
            num1=Convert.ToInt32(Console.ReadLine());
            kilometre = num / 1000;
            metre = num1 * 1000;
            Console.WriteLine("Kilometre" +" " + kilometre);
            Console.WriteLine("metres" + " " +metre);
            Console.ReadLine();
        }
    }
}
