using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secondday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            float radius;
            float pi = 3.14f;
            Console.WriteLine("enter radius");
            radius = Convert.ToInt32(Console.ReadLine());

            double area = pi * radius * radius;
            Console.WriteLine(area);
            Console.WriteLine("====================================================================");



            string name;
            DateTime bdate;
            Console.WriteLine("Enter a string");
            name = Console.ReadLine();
            Console.WriteLine("Enter your date of birth");
            bdate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Hello " + name);
            Console.WriteLine("You entered date as = " + bdate);
            CalculateAge(bdate);
        }
        static void CalculateAge(DateTime birthdate)
        {
            int currentDate = DateTime.Now.Year;
            int byear = birthdate.Year;
            int age = currentDate - byear;
            Console.WriteLine("Your age as per your birth date= " + age);
            Console.ReadLine();
        }
        
    }
}
