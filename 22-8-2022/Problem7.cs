Problem 7

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Problem_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue my = new Queue();
            my.Enqueue(12);
            my.Enqueue(34.56);
            my.Enqueue("Hello");
            Console.WriteLine("Before Dequeue");
            foreach (var item in my)
            {
                Console.WriteLine(item);    
            }
            my.Dequeue();
            Console.WriteLine("------------------------After Dequeue-----------------------------");
            foreach (var item in my)
            {
                Console.WriteLine(item);
            }
            object o = my.Peek();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("The Peek is " +o);
            Console.ReadLine();
        }
    }
}
