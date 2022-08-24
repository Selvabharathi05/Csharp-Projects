using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number");
            int i=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third number");
            int k = Convert.ToInt32(Console.ReadLine());
            int l = i * j * k;
            Console.WriteLine(l);
            Console.ReadLine();

        }
    }
}
