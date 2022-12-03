using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignmentSubmission
{
    public class Person
    {
        public int Age;
        public string Name;

        public Person(string name) : this(20, name) //can take in only the name, and assigns default age of 20 if needed
        {
        }
        public Person(int age, string name) //constructor that takes in age, name
        {
            this.Age = age;
            this.Name = name;
        }
    }
}
