using _6seplibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static _6seplibrary.Current;

namespace _6sep_pr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p;
            p = new Employee();
            p.Work();
            p = new Manager();
            p.Work();
            p = new Clerk();
            p.Work();    

            Savings savings = new Savings();
            savings.Calculateinterest();
            Current current = new Current();
            current.Calculateinterest();

            bank banking = new bank();



            banking.current();
            banking.savings();
            banking.deposits();
            banking.withdraw();
            banking.total_balc();
            banking.deposits1();
            banking.withdraw1();
            banking.total_balc1();
            Console.ReadLine(); 

        }
    }
}

========================================================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _6seplibrary.Current;

namespace _6seplibrary
{
    public abstract class Person
    {
        public abstract void Work();
       
    }

    public class Employee : Person
    {
       public override  void Work()
        {
            Console.WriteLine("This is from Employee class");
        }

    }
    public class Manager : Person
    {
        public override void Work()
        {
            Console.WriteLine("This is from Manager class");
        }

    }
    public class Clerk : Person
    {
        public override void Work()
        {
            Console.WriteLine("This is from clerk class");
        }
    }

    interface IBank
    {
        void Calculateinterest();
        int PrintBalance();
    }
    public class Savings : IBank
    {
        public void Calculateinterest()
        {
            double r = 4, Pamt, interest;
            int time;
            Console.WriteLine("Enter Principal Amount");
            Pamt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of years");
            time = Convert.ToInt32(Console.ReadLine());
            interest = Pamt * r * time / 100;
            double total = Pamt + interest;
            Console.WriteLine("Savings Account");
            Console.WriteLine("Interst in {0} years :{1}", time, interest);
            Console.WriteLine("Total Amount :" + total);
            Console.WriteLine("-----------------------------------");

        }

        public int PrintBalance()
        {
            throw new NotImplementedException();
        }

    }

    public class Current : IBank
    {
        public void Calculateinterest()
        {
            double r = 2, Pamt, interest;
            int time;
            Console.WriteLine("Enter Principal Amount");
            Pamt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of years");
            time = Convert.ToInt32(Console.ReadLine());
            interest = Pamt * r * time / 100;
            Console.WriteLine("Current Account");
            Console.WriteLine("Interst in {0} years :{1}", time, interest);
            double total = Pamt + interest;
            Console.WriteLine("Total Amount :" + total);

        }

        public int PrintBalance()
        {
            throw new NotImplementedException();
        }

        public class bank
        {
            public int x, y;
            public bank()
            {
                x = 1000;
                y = 2000;
            }


        }
       
    }
    public static class curr
    {

        public static void current(this bank obj)
        {
            Console.WriteLine("current balance " + obj.x);
        }
        public static void deposits(this bank obj)
        {
            Console.WriteLine("enter the amount to deposit in current aacnt");
            int dep = Convert.ToInt32(Console.ReadLine());
            obj.x = dep + obj.x;
            Console.WriteLine("AMOUNT DEPOSITED");
        }
        public static void withdraw(this bank obj)
        {
            Console.WriteLine("enter the amount to withdraw in current aacnt");
            int with = Convert.ToInt32(Console.ReadLine());
            if (with < obj.x)
                obj.x = obj.x - with;
            else
                Console.WriteLine("amount can't be withdraw");
            Console.WriteLine("AMOUNT WITHDRAW");

        }
        public static void total_balc(this bank obj)
        {
            Console.WriteLine("total balance in current aacnt " + obj.x);
        }
    }
    public static class sav
    {

        public static void savings(this bank obj)
        {
            Console.WriteLine("saving balance" + obj.y);
        }
        public static void deposits1(this bank obj)
        {
            Console.WriteLine("enter the amount to deposit in savings accnt");
            int dep = Convert.ToInt32(Console.ReadLine());

            obj.y = dep + obj.y;
            Console.WriteLine("AMOUNT DEPOSIT");
        }
        public static void withdraw1(this bank obj)
        {
            Console.WriteLine("enter the amount to withdraw in savings accnt");
            int with = Convert.ToInt32(Console.ReadLine());
            if (with < obj.y)
                obj.y = obj.y - with;
            else
                Console.WriteLine("amount can't be withdraw");
            Console.WriteLine("AMOUNT WITHDRAW");
        }
        public static void total_balc1(this bank obj)
        {
            Console.WriteLine("total balance in current account " + obj.y);
        }
    }
}

   
 

