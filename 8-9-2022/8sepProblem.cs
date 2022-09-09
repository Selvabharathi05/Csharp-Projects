using _8seplibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_sep_Problem
{
    public delegate void Empop(Employee e);
    public delegate void Printing();
    public class Empoperations : EventArgs
    {
        public static event Empop Addevent;
        public static event Empop Updateevent;
        public static event Empop Deleteevent;

        static void Main(string[] args)
        {
            Action<string, string> checkcredentials = (u1, p1) =>
            {
                if (u1 != "" && u1 == "Selva" && p1 != "" && p1 == "abc@123")
                {
                    Console.WriteLine("Employee logged in successfully");
                }
                else
                {
                    Console.WriteLine("Pls check Username/password");
                }
            };
            Console.WriteLine("Enter Username");
            string u = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string p = Console.ReadLine();
            checkcredentials(u, p);
            Console.WriteLine("---------------------------");
            Addevent += Empop_Addevent;
            Updateevent += Empop_Updateevent;
            Deleteevent += Empop_Deleteevent;

            do
            {
                Console.WriteLine("Menu \n 1 for Add Employee \n 2 for Update Employee \n 3 for Delete Employee");
                int choice = Convert.ToInt32(Console.ReadLine());
                Employee e = new Employee();
                switch (choice)
                {
                    case 1:

                        Console.WriteLine("Enter Employee ID");
                        e.EmployeeID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name");
                        e.EmployeeName = Console.ReadLine();
                        Console.WriteLine("Enter phone no");
                        e.DeptNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the location");
                        e.Location = Console.ReadLine();
                        Console.WriteLine("Enter Department Name");
                        e.DeptName = Console.ReadLine();
                        Console.WriteLine("Enter Salary");
                        e.Salary = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Enter the Manager Name");
                        e.Manager = Console.ReadLine();
                        Addevent(e);
                        break;
                    case 2:

                        Console.WriteLine("Enter Employee ID");
                        e.EmployeeID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name");
                        e.EmployeeName = Console.ReadLine();
                        Console.WriteLine("Enter phone no");
                        e.DeptNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the location");
                        e.Location = Console.ReadLine();
                        Console.WriteLine("Enter Department Name");
                        e.DeptName = Console.ReadLine();
                        Console.WriteLine("Enter Salary");
                        e.Salary = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Enter the Manager Name");
                        e.Manager = Console.ReadLine();
                        Updateevent(e);
                        break;
                    case 3:
                        Console.WriteLine("Enter Employee Id");
                        e.EmployeeID = Convert.ToInt32(Console.ReadLine());
                        Deleteevent(e);
                        break;
                    default:
                        Environment.Exit(1);
                        break;
                }

            } while (true);

        }
        private static void Empop_Deleteevent(Employee e)
        {
            Empoperations operations = new Empoperations();
            Empop emp = new Empop(operations.DeleteEmployee);
            emp(e);
        }

        private static void Empop_Updateevent(Employee e)
        {
            Empoperations operations = new Empoperations();
            Empop emp = new Empop(operations.UpdateEmployee);
            emp(e);
        }

        private static void Empop_Addevent(Employee e)
        {

            Empoperations operations = new Empoperations();
            Empop emp = new Empop(operations.AddEmployee);
            emp(e);
        }

        public static int num = 0;

        public void Addcount()
        {
            num += 1;
            Console.WriteLine("---------------------------");
            Console.WriteLine("You Added {0} Employee", num);
            Console.WriteLine("---------------------------");
        }
        public static List<Employee> emplist = new List<Employee>();
        public void AddEmployee(Employee e)
        {
            if (num <= 10)
            {
                emplist.Add(e);
                Console.WriteLine("Employee Added Successfully");
            }
            else
            {
                Console.WriteLine("Cannot Add more than 10 Employees");
            }
            Addcount();
            PrintEmployee();


        }

        public void UpdateEmployee(Employee e)
        {
            Employee found = emplist.Find(x => x.EmployeeID == e.EmployeeID);
            found.EmployeeName = e.EmployeeName;
            found.Salary = e.Salary;
            found.Location = e.Location;
            found.Manager = e.Manager;
            found.DeptNo = e.DeptNo;
            Console.WriteLine("Updated Successfully");
            Console.WriteLine("---------------------------");
            PrintEmployee();
        }

        public void DeleteEmployee(Employee e)
        {
            emplist.RemoveAll(x => x.EmployeeID == e.EmployeeID);
            Console.WriteLine("Deleted Successfully");
            Console.WriteLine("------------------------");
            PrintEmployee();

        }



        public void PrintEmployee()
        {
            foreach (Employee e in emplist)
            {
                Console.WriteLine("Employee Id :" + e.EmployeeID);
                Console.WriteLine("Employee Name :" + e.EmployeeName);
                Console.WriteLine("Salary :" + e.Salary);
                Console.WriteLine("Location :" + e.Location);
                Console.WriteLine("Manager :" + e.Manager);
                Console.WriteLine("Deparment Number" + e.DeptNo);
                Console.WriteLine("-------------------------------------");
                Displaybymgr(Employee m);

            }
        }
        public void Displaybymgr(List<Employee> m)
        {
            Console.WriteLine("Enter the name of the manager whom name of employees you want to see ");
            string s = Console.ReadLine();
            var ti = m.Where(mi => mi.Manager == s).ToList();
            if (ti.Count > 0)
            {
                foreach (var item in ti)
                    Console.WriteLine(item.EmployeeName);
            }
            else
            {
                Console.WriteLine("No employees is working under him");
            }
        }

    }

}
==============================================================================



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8seplibrary
{
    public class Dept
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }
    }

    public class Employee:Dept
    {
        public int EmployeeID { get; set; } 

        public string EmployeeName { get; set; }

        public float   Salary { get; set; }

        public string Manager { get; set; }

    }
}
============================================================================
