using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Sum is" +" "+ add());
            Console.ReadLine();
        }
        static int add()
        {
            int a, b, sum;
            Console.WriteLine("Enter First Number");
            a =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b = Convert.ToInt32(Console.ReadLine());
            sum = a + b;
            return sum;
        }
    }
}
