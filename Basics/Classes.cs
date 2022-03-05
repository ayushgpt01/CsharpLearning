using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Classes
{
    class Book
    {
        public string title;
        public static int count = 0;
        public string author;
        public int pages;
        private int profit;

        public Book(string title, int profit, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            Profit = profit;
            count++;
        }

        public void Info()
        {
            Console.WriteLine("{0} pages long book {1} is written by {2}",pages,title,author);
        }

        public int Profit
        {
            get { return profit; }
            set { profit = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Blood of Elves",1000,"Andrzej Sapkowski",320);
            Console.WriteLine("Title : " + book.title);

            Book book1 = new Book("Time of Contempt",20000,"Andrzej Sapkowski",352);
            Console.WriteLine("Title : " + book1.title);
            book.Profit = 3000;
            Console.WriteLine(book.Profit);
            book.Info();
            book1.Info();
            Console.WriteLine("Total num of books : " + Book.count);
        }
    }
}