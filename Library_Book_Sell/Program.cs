using System;
using Library_Book_Sell.Models;

namespace Library_Book_Sell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("The Lord of the Rings", 35, "J.R.R. Tolkien", 1500)
            {
                Count = 15
            };
            Book book2 = new Book("To Kill a Mockingbird", 54, "Harper Lee", 1200)
            {
                Count = 60
            }; 
            Book book3 = new Book("1984", 10, "George Orwell", 760)
            {
                Count = 9
            }; 
            Book book4 = new Book("The Hobbit", 25, "J.R.R. Tolkien", 1600)
            {
                Count = 23
            }; 
            Book book5 = new Book("Fahrenheit 451", 13, "J.R.R. Tolkien", 700)
            {
                Count = 23
            };




            Library library = new Library(5);

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            
            library.GetAllBooks();

            Console.WriteLine("Sell method ----------\n");
            book1.Sell(8);
            Console.WriteLine("__________ \n");

            library.GetAllBooks();
            book2.Sell(3);
            Console.WriteLine("GetBookById \n");

            library.GetBookById(2);

            Console.WriteLine("\n Remove-------------- \n");

            library.RemoveById(2);



        }
    }
}
