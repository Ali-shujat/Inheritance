using System;
using System.Text;

namespace Mankind
{
    class Worker : Human
    {
        private decimal salaryWeek;
        private int dailyHour;
        private decimal perHour;

        public Worker(string firstName, string lastName,decimal weekSalary,int dailyHour) :base (firstName,lastName)
        {
            this.SalaryWeek = weekSalary;
            this.DailyHour = dailyHour;

        }
        public decimal PerHour
        {
            get { return (SalaryWeek/7)/DailyHour; }
            set { perHour = value; }
        }
        public int DailyHour
        {
            get { return dailyHour; }
            set { if (value < 1 || value > 12)
                    throw new ArgumentException("Expected value mismatch! Argument: working Hours Per Day");
                dailyHour = value; }
        }
        public decimal SalaryWeek
        {
            get { return salaryWeek; }
            set
            {
                if (value < 10)
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                salaryWeek = value;
            }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Type: {this.GetType().Name}")
                            .AppendLine($"FirstName: {this.FirstName}")
                            .AppendLine($"LastName: {this.LastName}")
                            .AppendLine($"Salary per Week:{this.SalaryWeek}")
                            .AppendLine($"Hours per day: {this.DailyHour}")
                            .AppendLine($"Salary per Hour: {this.PerHour:f2}");
           
            //stringBuilder.Append(
            //    $"FirstName: {this.FirstName}, LastName: {this.LastName}, Salary per Week:{this.SalaryWeek}" +
            //    $"\n Hours per day: {this.DailyHour}, Salary per Hour: {this.PerHour:f2}");
            return stringBuilder.ToString();
        }

    }
}
