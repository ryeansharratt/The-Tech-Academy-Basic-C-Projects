using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now; //new datetime object
            Console.WriteLine("Current time is " + DateTime.Now); //writing current datetime to console
            Console.WriteLine("Enter a number please: ");
            int X = Convert.ToInt32(Console.ReadLine()); //assigning user input to X

            DateTime dt1 = dt.AddHours(X); //new datetime object to store updated datetime from adding X to current time
            Console.WriteLine("Updated time is: " + dt1); //writing new time to console
            Console.ReadLine();
        }
    }
}
