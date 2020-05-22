using System;

namespace Mankind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- INHERITANCE! -----");
            Console.WriteLine("Man-kind!");

            try
            {
                Console.WriteLine("Please Enter Person First Name: ");
                string fName = Console.ReadLine();
                Console.WriteLine("Please Enter Person Last Name: ");
                string lName = Console.ReadLine();
                Console.WriteLine("Please Enter facultyNum:");
                string facultyNum = Console.ReadLine();
                Console.WriteLine("Please Enter weekly Salary:");
                decimal weekSalary = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter working hour per day:");
                int dailyHour = int.Parse(Console.ReadLine());

                //Human human = new Human(fName,lName);
                Student student = new Student(fName, lName, facultyNum);
                Worker worker = new Worker(fName, lName, weekSalary, dailyHour);
                Console.WriteLine(student + Environment.NewLine);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            Console.ReadKey();

        }
    }
}
