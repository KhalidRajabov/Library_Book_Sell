using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Book_Sell.Models
{
    internal class Library
    {
        public int BookLimit { get; set; }
        public Book[] Books = new Book[0];
        public Library(int booklimit)
        {
            BookLimit = booklimit;
        }

        public void AddBook(Book books)
        {
            if (Books.Length <= BookLimit)
            {
                Array.Resize(ref Books, Books.Length + 1);
                Books[Books.Length - 1] = books;
            }
            else
            {
                Console.WriteLine("Out of limit");
            }
        }
        public void GetBookById(int? id)
        {


            foreach (var i in Books)
            {
                if (i.Id == id)
                {
                    i.ShowInfo();
                    break;
                }

            }
            if (id == null)
            {
                Console.WriteLine("Not found");
            }

        }
        public void RemoveById(int? id)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Book[] bk = new Book[Books.Length - 1];
            for (int i = 0; i < Books.Length - 1; i++)
            {
                if (Books[i].Id != id)
                {
                    bk[i] = Books[i];

                    bk[i].ShowInfo();
                    Console.WriteLine("---------------\n");
                }
            }
        }
        public void GetAllBooks()
        {
            foreach (var item in Books)
            {
                Console.WriteLine($"Book Id: {item.Id} \n" +
                    $"Book name: {item.Name}\n" +
                    $"Book author: {item.Author}\n" +
                    $"Book page: {item.PageCount}\n" +
                    $"Book price: {item.Price}\n" +
                    $"Book in stock: {item.Count}\n" +
                    $"");
            }
        }
    }
}
