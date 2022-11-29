using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdbaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        { 
            List<Employee> Employees = new List<Employee>(); //employees list
            Employees.Add(new Employee("Joe", "Wookie", 12));
            Employees.Add(new Employee("Lisa", "Lamb", 13));
            Employees.Add(new Employee("Ryean", "Letwin", 17));
            Employees.Add(new Employee("Ethan", "Gilmore", 3));
            Employees.Add(new Employee("Jaden", "Letwin", 11));
            Employees.Add(new Employee("Joe", "Harlow", 2));
            Employees.Add(new Employee("Madyn", "Stanko", 23));
            Employees.Add(new Employee("Erin", "Mess", 4));
            Employees.Add(new Employee("Mica", "Huckle", 30));
            Employees.Add(new Employee("Corden", "Lee", 25));

            List<Employee> sameName = new List<Employee>(); //new list for Joe's to go into
            Console.WriteLine("These employees have the same first name: ");
            foreach (Employee employee in Employees) //foreach to find all Joe's and add to list
            {
                if(employee.FirstName == "Joe")
                {
                    sameName.Add(employee);
                    Console.WriteLine(employee.FirstName + " " + employee.LastName + ", " + employee.Id);
                }
            }
            Console.ReadLine();

            //lambda to find all Joe's
            foreach (Employee employee in Employees.Where(x => x.FirstName == "Joe").ToList())
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id);  
            }
            Console.ReadLine();

            //lambda for id's  GOOD
            Console.WriteLine("Employees with ID number greater than 5: ");
            foreach (Employee employee in Employees.FindAll(x => (x.Id >= 5)).ToList()) //id numbers greater than 5 lambda
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id);
            }
            Console.ReadLine();
        }
    }
}
