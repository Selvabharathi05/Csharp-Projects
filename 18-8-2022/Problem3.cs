using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i ,j;
            Console.WriteLine("Enter value for i");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for j");
            j = Convert.ToInt32(Console.ReadLine());
            int k = i + j;
            Console.WriteLine(k);
            int k1 = i - j;
            Console.WriteLine(k1);
            int k2 = i * j;
            Console.WriteLine(k2);
            int k3 = i / j;
            Console.WriteLine(k3);
            int k4 = i % j;
            Console.WriteLine(k4);
            Console.ReadLine();
        }
    }
            

  
        }
    

