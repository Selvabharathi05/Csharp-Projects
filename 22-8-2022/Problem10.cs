Problem 10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Problem_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Hello");
            dict.Add(2, "Welcome");
            dict.Add(3, "to");
            dict.Add(4, "C#");
            foreach (KeyValuePair<int,string> item in dict)
            {
                Console.WriteLine(item.Key +" "+ item.Value);

            }
            Console.ReadLine(); 
        }
    }
}
