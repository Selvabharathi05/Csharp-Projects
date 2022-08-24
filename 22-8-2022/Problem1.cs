Problem 1


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numarray = new int[10];
            Console.WriteLine("Enter the values for array ");
            for (int i = 0; i < numarray.Length; i++)
            {
                Console.Write("elemnt -[{0}] ", i);
                numarray[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var item in numarray)
            {
                Console.Write(item + "\t");
            }
            Console.ReadLine();
        }
    }
}
