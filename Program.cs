using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int k;
            Console.WriteLine("Enter value for i");
            i =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for j");
            j = Convert.ToInt32(Console.ReadLine());
            k = i + j;
            Console.WriteLine("The value of k is" +" "+ k);
            Console.ReadLine(); 

        }
    }
}
