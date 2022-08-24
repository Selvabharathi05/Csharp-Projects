Problem 15

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Problem_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 5, 3, 4, 3, 5, 6 };
            int k = -1;
            int n = arr.Length;
            HashSet<int> set = new HashSet<int>();
            for (int i = n-1; i >= 0; i--)
            {
                if (set.Contains(arr[i]))
                {
                    k = i;
                    
                }
                else
                {
                    set.Add(arr[i]);
                }   
            }
            if(k != -1)
            {
                Console.WriteLine(" First Repeating Element" +" "+ arr[k]);
            }
            else
            {
                Console.WriteLine("No Repeating Elements");
            }
            Console.ReadLine(); 
        }


    }
}
