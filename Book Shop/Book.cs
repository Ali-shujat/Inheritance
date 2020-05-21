using System;
using System.Linq;
using System.Text;

namespace Book_Shop
{
    public class Book
    {
        private string author;
        private string title;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public virtual string Author
        {
            get { return author; }
            set
            {
                if (value.Any(char.IsDigit)) throw new ArgumentException("Author not valid!");
                author = value;
            }
        }
        public virtual string Title
        {
            get { return title; }
            set
            {
                if (value.Length < 3) throw new ArgumentException("Title not valid!");
                title = value;
            }
        }
        public virtual decimal Price
        {
            get { return price; }
            set
            {
                if (value <= 0) throw new AggregateException("Price not valid!");
                this.price = value;
            }
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:f2}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}