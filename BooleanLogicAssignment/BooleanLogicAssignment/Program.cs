using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! \nWhat is your age?"); //first q, asks for input
            int ageAnswer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? True/False."); //second q, asks for input, has to write true or false
            string duiAnswer = Console.ReadLine();
            bool myBool = Convert.ToBoolean(duiAnswer); //converting to boolean values
          
            Console.WriteLine("How many speeding tickets have you had?"); //third q, asks for input
            int ticketsAnswer = Convert.ToInt32(Console.ReadLine());

            bool doesQualify = (ageAnswer > 15 && myBool == false && ticketsAnswer <= 3); //combining operators to achieve true or false based on user input
            Console.WriteLine("Qualifies for insurance? \n" + doesQualify); //will return true/false result
            Console.ReadLine();





            //string duiAnswer = Console.ReadLine(); //????????
            //if (duiAnswer == "yes")
            //{
            //    Console.WriteLine("True");
            //}
            //else if (duiAnswer == "no")
            //{
            //    Console.WriteLine("False");
            //}
            //Console.ReadKey();



        }
    }
}
