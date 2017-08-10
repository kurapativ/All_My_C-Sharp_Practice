using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07_VidyaPraveen_1447544

{
    class Book
    {

      

        public int bId {get;set;}
        public String bAuthor { get; set; }
        public String bTitle { get; set; }

        public Book(int bid, string bauthor, string btitle)
        {
            bId = bid;
            bAuthor = bauthor;
            bTitle = btitle;

        }


    }
        class myBooks:IEnumerable
    {
        List<Book> item = new List<Book>();
        public myBooks()
        {
            item.Add(new Book(01, "C# Fundamentals", "Dr. Steel"));
            item.Add(new Book(02, "AID Fundamentals", "Dr. Steel"));
            item.Add(new Book(03, "DataBase Fundamentals", "Dr. Saleem"));
            item.Add(new Book(04, "Networking Fundamentals", "Dr. Gercek"));
        }

        public IEnumerator GetEnumerator()
        {
            return item.GetEnumerator();
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            myBooks B = new myBooks();
            Console.WriteLine("BookID"+"\t"+"BookTitle" + "\t" + "BookAuthor");
            Console.WriteLine("---------------------------------------------");
            foreach(Book item  in B)
            {
                Console.WriteLine(item.bId+"\t"+item.bTitle+"\t"+item.bAuthor);
            }
            Console.ReadLine();
        }
    }
}
