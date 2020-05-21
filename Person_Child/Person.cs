using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Child
{
    public class Person
    {
        private string name;

        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;

        public virtual int Age
        {
            get { return age; }
            set
            {
                if (value < 1) throw new ArgumentException("Age of person should not be negative");
                age = value;
            }
        }

        public Person(string nam, int ag)
        {
            this.Age = ag;
            this.Name = nam;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}", this.Name,this.Age));
            return stringBuilder.ToString();
        }
    }
}
