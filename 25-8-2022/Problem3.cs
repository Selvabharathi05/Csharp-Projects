using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory("D:\\C#\\25\\25 Problem 3\\Results");
            //Console.WriteLine("Directory Successfully Created");

            //Directory.CreateDirectory("D:\\C#\\25\\25 Problem 3\\Results\\Results17-18");
            //Console.WriteLine("Results17-18 Subdirectories Created");

            //Directory.CreateDirectory("D:\\C#\\25\\25 Problem 3\\Results\\Results18-19");
            //Console.WriteLine("Results18-19 Subdirectories Created");

            //Directory.CreateDirectory("D:\\C#\\25\\25 Problem 3\\Results\\Results20-21");
            //Console.WriteLine("Results20-21 Subdirectories Created");

            //string path = "D:\\C#\\25\\25 Problem 3\\Results\\";
            //Console.WriteLine("Enter File Name");
            //string fname = Console.ReadLine();
            //fname = string.Concat(path, fname);

            //File.Create(fname);
            //Console.WriteLine("File Created Successfully");


            //string path = "D:\\C#\\25\\25 Problem 3\\Results\\Results17-18\\";
            //Console.WriteLine("Enter File Name");
            //string fname = Console.ReadLine();
            //fname = string.Concat(path, fname);

            //File.Create(fname);
            //Console.WriteLine("File Created Successfully");

            //string path = "D:\\C#\\25\\25 Problem 3\\Results\\Results18-19\\";
            //Console.WriteLine("Enter File Name");
            //string fname = Console.ReadLine();
            //fname = string.Concat(path, fname);

            //File.Create(fname);
            //Console.WriteLine("File Created Successfully");

            //string path = "D:\\C#\\25\\25 Problem 3\\Results\\Results20-21\\";
            //Console.WriteLine("Enter File Name");
            //string fname = Console.ReadLine();
            //fname = string.Concat(path, fname);

            //File.Create(fname);
            //Console.WriteLine("File Created Successfully");


            //Directory.CreateDirectory("D:\\C#\\25\\25 Problem 3\\Results\\Results17-18\\January");
            //Directory.CreateDirectory("D:\\C#\\25\\25 Problem 3\\Results\\Results17-18\\February");
            //Directory.CreateDirectory("D:\\C#\\25\\25 Problem 3\\Results\\Results17-18\\March");
            //Directory.CreateDirectory("D:\\C#\\25\\25 Problem 3\\Results\\Results17-18\\April");
            //Console.WriteLine("Months Of Folder Created");

            //Directory.CreateDirectory("D:\\C#\\25\\25 Problem 3\\Results\\Results18-19\\May");
            //Directory.CreateDirectory("D:\\C#\\25\\25 Problem 3\\Results\\Results18-19\\June");
            //Directory.CreateDirectory("D:\\C#\\25\\25 Problem 3\\Results\\Results18-19\\July");
            //Directory.CreateDirectory("D:\\C#\\25\\25 Problem 3\\Results\\Results18-19\\August");
            //Console.WriteLine("Months Of Folder Created");

            //Directory.CreateDirectory("D:\\C#\\25\\25 Problem 3\\Results\\Results20-21\\September");
            //Directory.CreateDirectory("D:\\C#\\25\\25 Problem 3\\Results\\Results20-21\\October");
            //Directory.CreateDirectory("D:\\C#\\25\\25 Problem 3\\Results\\Results20-21\\November");
            //Directory.CreateDirectory("D:\\C#\\25\\25 Problem 3\\Results\\Results20-21\\December");
            //Console.WriteLine("Months Of Folder Created");

            //string[] fname = Directory.GetFiles("D:\\C#\\25\\25 Problem 3\\Results");
            //foreach (var item in fname)
            //{
            //    Console.WriteLine("Files in Results Directory" + item);
            //}

            //string[] fname = Directory.GetFiles("D:\\C#\\25\\25 Problem 3\\Results\\Results17-18");
            //foreach (var item in fname)
            //{
            //    Console.WriteLine("Files in Results17-18 Directory" + item);
            //}

            //string[] fname = Directory.GetFiles("D:\\C#\\25\\25 Problem 3\\Results\\Results18-19");
            //foreach (var item in fname)
            //{
            //    Console.WriteLine("Files in Results18-19 Directory" + item);
            //}

            //string[] fname = Directory.GetFiles("D:\\C#\\25\\25 Problem 3\\Results\\Results20-21");
            //foreach (var item in fname)
            //{
            //    Console.WriteLine("Files in Results20-21 Directory" + item);
            //}


            string[] dirs = Directory.GetDirectories("D:\\C#\\25\\25 Problem 3\\Results");
            foreach (var item in dirs)
            {
                Console.WriteLine("Directories in Results" + item);
                string[] fnames = Directory.GetFiles(item);
                foreach (var item1 in fnames)
                {
                    
                    Console.WriteLine("Files in Results" +item1);
                }
            }

            Console.ReadLine();
        }
    }
}
