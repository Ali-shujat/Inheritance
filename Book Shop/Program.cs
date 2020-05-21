using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Inheritance!**********");
            Console.WriteLine("Problem 2. Book Shop");

            try {
                string author = Console.ReadLine();
                string title = Console.ReadLine();
                decimal price = decimal.Parse(Console.ReadLine());
                Book book = new Book(author, title, price);
                GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);
                Console.WriteLine(book + Environment.NewLine);
                Console.WriteLine(goldenEditionBook);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            Console.ReadKey();

        }
    }
}
