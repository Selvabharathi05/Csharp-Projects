using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] dinfo = DriveInfo.GetDrives();
            foreach (var item in dinfo)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("----------------------------");

            Console.WriteLine("C drive info");
            DriveInfo info = new DriveInfo("C");
            Console.WriteLine(info.Name);
            Console.WriteLine(info.TotalSize);
            Console.WriteLine(info.DriveType);
            Console.WriteLine(info.DriveFormat);
            
            Console.ReadLine();
        }
    }
}
