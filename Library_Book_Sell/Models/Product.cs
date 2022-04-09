using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Book_Sell.Models
{
    abstract class Product
    {
        private static int _id=0;
        private static int _count=0;
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count 
        {
            get 
            {
                return _count; 
            }
                
            set 
            {
                _count = value; 
            }
        }
        public int Id 
        {
            get 
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
        protected double TotalIncome { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            _id++;
            _count++;
        }

        public abstract void Sell(int num);
        public abstract void ShowInfo();
    }
}
