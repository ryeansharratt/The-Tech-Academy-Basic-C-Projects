using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:"); //user input
            var userInput = Convert.ToInt32(Console.ReadLine()); //reading input, assigning to variable userInput

            var mathOperator = new MathOperation(); //assigning the class MathOperation to var mathOperator
            var result = mathOperator.Addition(userInput); //var result assigned to calling the Addition method from the class MathOperation (assigned var mathOperator), passing user input to method
            Console.WriteLine(result); //displaying final total result; which will be the user's number after being put through each method
            Console.ReadLine();
            result = mathOperator.Division(userInput); //same but taking result from last method, calling Division method 
            Console.WriteLine(result); //displaying final total result; which will be the user's number after being put through each method
            Console.ReadLine();
            result = mathOperator.Multiply(userInput); //same but taking result from last method, calling Multiply method to finish the math operations on the user's input
            Console.WriteLine(result); //displaying final total result; which will be the user's number after being put through each method
            Console.ReadLine();

        }
    }
}
