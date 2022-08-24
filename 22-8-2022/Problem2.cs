Problem 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] myarray = new int[3];
            Console.Write("Input the number of elements to store in the array :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter {0} elements to store in the array  ", n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Element -{0} ", i);
                myarray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The  Actual values Stored in the array");
                foreach (var item in myarray)
            {
                Console.Write(item +"\t");
            }
            Array.Sort(myarray);
            Array.Reverse(myarray);
            Console.WriteLine("\n After Reversing");
            foreach (var item in myarray)
            {
                Console.Write(item + "\t");
            }
            Console.ReadLine();
           
        }
    }
}
