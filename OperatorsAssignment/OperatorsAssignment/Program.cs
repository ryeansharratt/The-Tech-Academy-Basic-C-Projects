using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(); //new Employee object
            employee1.ID = 20;
            employee1.FirstName = "Ryean";
            employee1.LastName = "Sharratt";

            Employee employee2 = new Employee(); //new Employee object
            employee2.ID = 13;
            employee2.FirstName = "Jaden";
            employee2.LastName = "Letwin";

            Console.ReadLine();

        }
    }
}
