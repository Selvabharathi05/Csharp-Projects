PROBLEM 7


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Problem_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mark1, mark2, mark3,total;
            double percentage;
            Console.WriteLine("Enter The First Subject mark");
            mark1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second Subject mark");
            mark2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Third Subject mark");
            mark3 = Convert.ToInt32(Console.ReadLine());
            total = mark1 + mark2+ mark3;
            Console.WriteLine("Total Marks"+" "+ total);
            percentage = total / 3.0f;
            Console.WriteLine("Total Percentage" + " " + percentage);
            if (percentage < 35)
            {
                Console.WriteLine("Fail");
            }
            else if (percentage < 45 && percentage >= 35) 
            {
                Console.WriteLine("Third");
            }
            else if (percentage < 60 && percentage >= 45) 
            {
                Console.WriteLine("Second");
            }
            else
            {
                Console.WriteLine("First");
            }
            Console.ReadLine();


        }
    }
}
