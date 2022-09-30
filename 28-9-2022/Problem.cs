using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BALLibrary;

namespace _28sep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookOperations bo = new BookOperations();
            List<BookBAL> books =bo.Getbooks(); 
            foreach (var item in books)
            {
                Console.WriteLine("Bookno :" + item.BookNo );
                Console.WriteLine("BookName :" + item.BookName);
                Console.WriteLine("Author :" + item.Author);
                Console.WriteLine("Bookcost :" + item.cost);
                Console.WriteLine("Category :" + item.Category);
                Console.WriteLine("-----------------------------------");
            }
            Console.ReadLine();
        }
    }
}
------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaLlibrary;

namespace BALLibrary
{
    public class BookOperations
    {
        public List<BookBAL> Getbooks()
        {
            Library_SystemEntities context = new Library_SystemEntities();
            List<book> Booklist = context.books.ToList();
            List<BookBAL> books = new List<BookBAL>();
            foreach (var item in Booklist)
            {
                books.Add(new BookBAL
                {
                    BookNo = (int)item.book_no,
                    BookName = item.book_name,
                    Author = item.author,
                    cost = (float)item.cost,
                    Category = item.category
                });
            }
            return books;   
        }
    }
}
------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALLibrary
{
    public class BookBAL
    {
        public int BookNo { get; set; }
        public string BookName { get; set; }

        public string Author { get; set; }

        public float cost { get; set; }

        public string Category { get; set; }
    }
}
