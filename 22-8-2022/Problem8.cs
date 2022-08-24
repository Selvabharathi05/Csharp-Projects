Problem 8

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Problem_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add(1, "Ford");
            h.Add(2, "Renault");
            h.Add(3, "TaTa");
            h.Add(4, "BMW");
            Console.WriteLine("Values in the HashTable");
            foreach (DictionaryEntry item in h)
            {
                Console.WriteLine(item.Key +" " + item.Value);
            }
            h.Remove(2);
            Console.WriteLine("-----------After Removing----------------");
            foreach(DictionaryEntry item in h)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.ReadLine();
        }
    }
}
