Problem 9


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int celcius,kelvin,fahren;
            Console.WriteLine("Enter the amount of celcius");
            celcius=Convert.ToInt32(Console.ReadLine());
            kelvin = celcius + 273;
            fahren = (celcius * 9 / 5) +32;
            Console.WriteLine("kelvin =" + kelvin);
            Console.WriteLine("fahrenheit =" + fahren);
            Console.ReadLine(); 

        }
    }
}
