PROBLEM 1


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,maxnumber,minnumber;
            Console.WriteLine("Enter the First Number");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            maxnumber=Math.Max(num1,num2);
            minnumber=Math.Min(num1,num2);
            Console.WriteLine("Large Number"+" "+ maxnumber);
            Console.WriteLine("Small Number" + " " + minnumber);
            Console.ReadLine(); 



        }
    }
}
