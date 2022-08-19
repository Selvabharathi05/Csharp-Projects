using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k =0, userchoice;
            char ch = '+';
            Console.WriteLine("Menu \n 1.Add \n 2.Subtract \n 3.Multiplication \n 4.Division \n 5.Exit");
            Console.WriteLine("Enter The First Number");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second Number");
            j = Convert.ToInt32(Console.ReadLine());
            userchoice = Convert.ToInt32(Console.ReadLine());
            

            switch (userchoice)
            {
                case 1:
                    ch = '+';
                    k = i + j;
                    break;
                case 2:
                    ch = '-';
                    k = i - j;
                    break;
                case 3:
                    ch = '*';
                    k = i * j;
                    break;
                case 4:
                    ch = '/';
                    k = i / j;
                    break;

                default:
                    Environment.Exit(1);
                    break;
            }
            Console.WriteLine("The answer of {0} {1} {2}={3}", i,ch, j,k);

            Console.ReadLine();
        }
    }
}
