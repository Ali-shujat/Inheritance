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
            stringBuilder.Append(String.Format("FirstName: {0}, LastName: {1}, FacultyNumber:{2}", this.FirstName, this.LastName,this.FacultyNumber));
            return stringBuilder.ToString();
        }

    }
}
