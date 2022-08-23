using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i =5 , j = 6;
            callbyvalue(i, j);
            callbyrefrence(ref i, ref j);
        }
        static void callbyvalue(int i, int j)
        {
            int k = i;
            i = j;
            j = k;
            Console.WriteLine("This is by Call by value");
            Console.WriteLine("value of i after swapped" + i);
            Console.WriteLine("value of j after swapped" + j);
            Console.WriteLine("=========================================");

        }
        static void callbyrefrence( ref int i,ref  int j)
        {
            int k = i;
            i = j;
            j = k;
            Console.WriteLine("This is by Call by refrence");
            Console.WriteLine("value of i after swapped" + i);
            Console.WriteLine("value of j after swapped" + j);
            Console.ReadLine();
        }
        
    }
}
