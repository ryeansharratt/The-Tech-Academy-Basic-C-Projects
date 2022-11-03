using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program"); //Person 1 block
            Console.ReadLine();
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?"); //asking hourly rate from user
            int hourRate1 = Convert.ToInt32(Console.ReadLine()); //declaring var person1 hourRate, taking input
            Console.WriteLine("Hours worked per week?"); //asking hours worked from user
            int hoursWorked1 = Convert.ToInt32(Console.ReadLine()); //declaring var hoursWorked, taking input

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?"); //asking hourly rate from user
            int hourRate2 = Convert.ToInt32(Console.ReadLine()); //declaring var person1 hourRate, taking input
            Console.WriteLine("Hours worked per week?"); //asking hours worked from user
            int hoursWorked2 = Convert.ToInt32(Console.ReadLine()); //declaring var hoursWorked, taking input

            //person 1 salary
            int product = hourRate1 * hoursWorked1; //declaring new var product, which is var above multiplied by each other
            int num1 = product * 52;
            Console.WriteLine("Annual salary of Person 1 is: " + product * 52); //writing string plus product above, times 52, for 52 weeks in a year (salary)
            Console.ReadLine();

            //person2 salary
            int product2 = hourRate2 * hoursWorked2; //same as above...
            int num2 = product2 * 52;
            Console.WriteLine("Annual salary of Person 2 is: " + product2 * 52);
            Console.ReadLine();

            //comparing salaries
            bool greaterThan = num1 > num2; //taking salary var's from above and true/falsing them, person1 salary greater than person2?
            Console.WriteLine("Person 1 makes more money than Person 2: \n" + greaterThan); //true or false? Based on input
            Console.ReadLine();



        }
    }
}
