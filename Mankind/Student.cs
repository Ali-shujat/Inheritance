using System;
using System.Text;

namespace Mankind
{
    class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNum) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNum;
        }

        public string FacultyNumber
        {
            get { return facultyNumber; }
            set
            {
                if (value.Length < 5 || value.Length > 10) throw new AggregateException("Invalid faculty number!");
                this.facultyNumber = value;
            }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Type: {this.GetType().Name}")
                            .AppendLine($"FirstName: {this.FirstName}")
                            .AppendLine($"LastName: {this.LastName}")
                            .AppendLine($"FacultyNumber: {this.FacultyNumber}");
            return stringBuilder.ToString();
        }

    }
}
