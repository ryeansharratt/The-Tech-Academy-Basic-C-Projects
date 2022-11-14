using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_A.Strings_and_Integers_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listNumbers = new List<int>() //list of integers
            {
                20, 45, 10, 23, 15, 8, 16
            };
            Console.WriteLine("Type a number to divide all the numbers by:");

            try
            {
                int userNumber = Convert.ToInt32(Console.ReadLine()); //user input
                foreach (decimal number in listNumbers) //using decimal here and below to display result more precisely
                {
                    decimal result = number / userNumber; //declaring new variable of divided list integers by user input
                    Console.WriteLine("Result is: " + result); //displays result 
                }
                Console.ReadLine();
            }
            catch (FormatException ex) //handling is user inputs a word
            {
                Console.WriteLine("Error, have to input a number.");
                return;
            }
            catch (DivideByZeroException ex) //handling a 0 input
            {
                Console.WriteLine("Please don't divide by 0.");
            }
            finally //runs no matter what
            {
                Console.ReadLine();
            }
            Console.WriteLine("Done with that block!");
            Console.ReadLine();
        }
    }
}
