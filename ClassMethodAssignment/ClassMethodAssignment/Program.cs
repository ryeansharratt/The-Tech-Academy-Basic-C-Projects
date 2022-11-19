using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    static class Program 
    {
        static void Main(string[] args)
        {
            FirstClass firstClass = new FirstClass(); //instantiate class

            Console.WriteLine("User, please enter a number: "); //have user enter a number
            int num1 = Convert.ToInt32(Console.ReadLine()); 

            firstClass.Math(num1); //calling method on user input num1

            firstClass.Math(out int num2, out int num3); //calling Math method with output parameters, also inlining variable declaration
            Console.ReadLine();

            SecondClass.Print();
        }
    }
}
