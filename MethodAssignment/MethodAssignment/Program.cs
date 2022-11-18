using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
           
                FirstClass firstClass = new FirstClass(); //instantiate new class
                Console.WriteLine("Enter a number: "); //user input 1
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("OPTIONAL Enter a second number: "); //optional user input 2
                string num2 = Console.ReadLine();
                

            if (num2 == "")
            {
                Console.WriteLine(firstClass.Math(num1));
                Console.ReadLine();
            }
            else //if user doesn't input second number
            {
                Console.WriteLine(firstClass.Math(num1, Convert.ToInt32(num2)));
                Console.ReadLine();
            }
        }
    }
}
