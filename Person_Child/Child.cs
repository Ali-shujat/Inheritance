using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Child
{
    public class Child : Person
    {

        public Child(string name , int age) :base (name, age)
        {


        }
        public override int Age
        {
            get => base.Age;
            set
            {
                if (value > 16) throw new ArgumentException("Age of Child should be less than 16");
                base.Age = value;
            }
        }


    }
}
