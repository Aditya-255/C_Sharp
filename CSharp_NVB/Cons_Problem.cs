using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_NVB
{
    class Book {
        int bookid;
        string booktitle;
        string bookauthor;
        int bookprice;

        public Book() {
            Console.Write("Enter the book id: ");
            bookid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the book title: ");
            booktitle = Console.ReadLine();
            Console.Write("Enter the book author: ");
            bookauthor=Console.ReadLine();
            Console.Write("Enter the book price: ");
            bookprice = Convert.ToInt32(Console.ReadLine());
        }

        public void print()
        {
            Console.WriteLine("book id is: " + bookid);
            Console.WriteLine("book title is: " + booktitle);
            Console.WriteLine("book author is: " + bookauthor);
            Console.WriteLine("book price is: " + bookprice);
        }


    }

    internal class Cons_Problem
    {
        public static void Main(string[] args)
        {
            Book []book = new Book[5];
            for (int i = 0; i < book.Length; i++)
            {
                book[i]=new Book();
            }
            Console.WriteLine("Book details are: ");
            for (int i = 0; i < book.Length; i++)
            {
                book[i].print();
                Console.WriteLine();
            }
        }
    }
}
