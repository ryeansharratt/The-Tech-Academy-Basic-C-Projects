using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstClass firstClass = new FirstClass(); //instantiate class
            Console.WriteLine(firstClass.Math(20)); //call the method, passing int 20 to it
            Console.ReadLine();

            FirstClass firstClass1 = new FirstClass(); //instantiating new class again
            Console.WriteLine(firstClass1.Math((decimal)Convert.ToInt32(20.5))); //calling 2nd method, converting decimal to integer
            Console.ReadLine();

            FirstClass firstClass2 = new FirstClass(); //instantiation
            Console.WriteLine(firstClass2.Math("10")); //calling method, passing a string of "10"
            Console.ReadLine();

        }
    }
}
