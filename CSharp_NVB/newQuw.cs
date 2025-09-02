using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_NVB
{
    public class Booked {
        int id;
        string title;
        string author;
        int pages;
        double oriprize;
        int ch;

        double dis1;
        double dis2;
        double dis3;
    public Booked(int id, string title, string author, int pages, double oriprize, int ch)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.oriprize = oriprize;
            this.ch = ch;
        }

        public void  Discount1()
        {
            dis1=oriprize-(oriprize*0.3);
        }
        public void Discount2()
        {
            dis2 = oriprize - (oriprize * 0.2);
        }
        public void Discount3()
        {
            dis3 = oriprize - (oriprize * 0.1);
        }
        public void showdetail()
        {
            Console.WriteLine("id is :" + id);
            Console.WriteLine("book name is: " + title);
            Console.WriteLine("author is : " + author);
            Console.WriteLine("pages is : " + pages);
            Console.WriteLine("price is : " + oriprize);
            Console.WriteLine("chapter in this : " + ch);
        }

        public void disprices()
        {
            if (pages > 500)
            {
                Discount1();
                Console.WriteLine(dis1);
            }
            else if(pages > 300)
            {
                Discount2();
                Console.WriteLine(dis2);
            }
            else
            {
                Discount3();
                Console.WriteLine(dis3);
            }
        }
    }

    internal class newQuw
    {
        public static void Main(String[] args)
        {
            Booked bb = new Booked(1, "maths", "abcd", 501, 100, 5);
            bb.showdetail();

            Console.WriteLine("discount prize is : "+bb.);
        }
    }
}
