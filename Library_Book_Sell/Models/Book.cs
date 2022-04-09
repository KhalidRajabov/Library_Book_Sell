using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Book_Sell.Models
{
    internal class Book:Product
    {
        public string Author { get; set; }
        public int PageCount { get; set; }

        public Book(string name, double price, string author, int pgcount  ):base(name, price)
        {
            Author = author;
            PageCount = pgcount;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Book id: {Id}\n" +
                $"Book name: {Name} \n" +
                $"Author: {Author} \n" +
                $"Page: {PageCount} \n" +
                $"Price: {Price} \n" +
                $"Count: {Count} \n" +
                $"Income {TotalIncome}");
        }


        public override void Sell(int num)
        {
            if (Count>0)
            {
                Count-=num;
                TotalIncome = Price*num;
            }
        }
    }
}
