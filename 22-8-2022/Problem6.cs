Problem 6


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Problem_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push("Hello");
            s.Push(1);
            s.Push("Welcome");
            s.Push(44.56);
            int count =s.Count;
            Console.WriteLine("Before pop");
            Console.WriteLine("count= "+count);
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            s.Pop();
            Console.WriteLine("------------------------------After pop--------------------------");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            count = s.Count;
            Console.WriteLine("count= "  +count);
            Console.WriteLine("----------------------------------");
            object o = s.Peek();
            Console.WriteLine("The topmost element on the stack = "+o);
            Console.ReadLine();
        }
    }
}
