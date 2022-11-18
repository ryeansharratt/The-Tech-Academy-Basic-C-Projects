using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee(); //instantiate new Employee object
            person.FirstName = "Sample"; //new object has first name
            person.LastName = "Student"; //new object has last name
            person.SayName(); //calling superclass method SayName() on employee oject
            Console.ReadLine();
        }
    }
}
