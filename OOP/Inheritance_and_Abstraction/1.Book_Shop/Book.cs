using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Book_Shop
{
    class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string title, string author, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get { return this.title; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Title cannot be empty OR Null");
                }
                this.title = value;
            }
        }

        public string Author
        {
            get { return this.author; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Author cannot be empty OR null ");
                }
                this.author = value;
            }
        }

        public virtual decimal Price
        {
            get { return this.price; }
           protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be negative");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("-Type: {0}\n-Title: {1}\n-Author: {2}\n-Price: {3}\n",
                this.GetType().Name, 
                this.Title,
                this.Author,
                this.Price);
        }
    }
}
