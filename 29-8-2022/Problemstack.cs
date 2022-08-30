using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Problem_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stackclass<string> s = new Stackclass<string>();
            s.Push("Hello");
            s.Push("All");
            s.Push("Welcome");
            s.Push("to");
            s.Push("my");
            s.Push("C#");
            Console.WriteLine("Popped element");
            s.Pop();
            Console.WriteLine("Present Elements");
            s.printData();
            Console.WriteLine("Top element at present");
            string k = s.Peek();
            Console.WriteLine(k);
            Console.ReadLine();



            Console.ReadLine();
        }
    }
}
=============================================================================================



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Problem_Stack
{
    internal class Stackclass<T>
    {
        internal static int max = 1000;
        T[] stack = new T[max];
        int top = -1;
        public void Push(T str)
        {
            if (top >= 1000)
            {
                Console.WriteLine("can't push");
            }
            else
            {
                stack[++top] = str;
            }
        }
        public void Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("No elements there to pop");
            }
            else
            {
                T value = stack[top--];
                Console.WriteLine(value);
            }
        }
        public T Peek()
        {
            if (top < 0)
            {
                return default(T);
            }
            else
            {
                T value = stack[top];
                return value;
            }
        }
        public void printData()
        {
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }
}
