using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Problem_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount");
            int amount =Convert.ToInt32(Console.ReadLine());
            int[] d = new int[] { 1, 2, 3 };
            int cnt;
            for (int i = 0; i < d.Length; i++)
            {
                if (amount % d[i] == 0)
                {
                    cnt = amount / d[i];
                    if (cnt != 0)
                    {
                        Console.WriteLine("{0} with the count of{1}", d[i], cnt);
                    }
                    else
                    {
                        Console.WriteLine("1 Problem");
                    }
                }

            }
            Console.ReadLine();

        }
    }
}
