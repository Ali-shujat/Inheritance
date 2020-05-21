using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Child
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance!");
            Console.WriteLine("Problem 1. Person_child !");

            Console.WriteLine("Please Enter Person Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please Enter Person Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            try
            {
                Child child = new Child(name, age);
                Console.WriteLine(child);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            Console.ReadKey();
        }
    }
}
