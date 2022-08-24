Problem 12

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Problem_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 23, 45, 67, 21, 65, 12, 90, 65 };
            int n = 8;
            int max = arr[0];
            int min = arr[0];
            max = arr[0];
            min = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Maximum element = {0} ", max);
            Console.WriteLine("Minimum element = {0} ", min);
            Console.ReadLine();

        }
    }
}
