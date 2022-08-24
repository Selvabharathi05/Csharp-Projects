Problem 11

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Problem_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList mylist = new SortedList();
            mylist.Add(2, "Welcome");
            mylist.Add(1, "Hello");
            mylist.Add(4, "C#");
            mylist.Add(3, "to");
            foreach (DictionaryEntry item in mylist)
            {
                Console.WriteLine(item.Key +" "+ item.Value);

            }
            Console.ReadLine();

        }
    }
}
