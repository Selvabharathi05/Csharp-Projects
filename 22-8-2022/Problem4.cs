Problem 4

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList newarray = new ArrayList(5);
            newarray.Add(1);
            newarray.Add(2);
            newarray.Add(3);
            newarray.Add(4);
            newarray.Add(5);
            foreach (var item in newarray)
            {
                Console.WriteLine(item);
            }
            newarray.Remove(4);
            Console.WriteLine("After Removing the number of elements: " + newarray.Count);
            
            Console.ReadLine();
        }
    }
}
