using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   
            Employee employee = new Employee(); //instantiate new Employee object
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName(); //calling method on object
            Console.ReadLine();

            IQuittable employee2 = new Employee(); //polymorphism to create object 
            Quit(employee2);
            void Quit(IQuittable quittable)
            {
                employee2.Quit(); //calling Quit() method on this object
            }
        }
    }
}
