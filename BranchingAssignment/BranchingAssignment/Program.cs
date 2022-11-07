using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opening line of program
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below. \nPlease enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine()); //User prompted for package weight and can input it in
            if (packageWeight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else //program will end if above "if" is met, if good to go, will continue with else...
            {
                //If weight is below 50, program can continue and user is prompted for package width, height, and length, respectively
                Console.WriteLine("Please enter the package width:");
                int packageWidth = Convert.ToInt32(Console.ReadLine()); //this line in each block declares that var to use later

                Console.WriteLine("Please enter the package height:");
                int packageHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                int packageLength = Convert.ToInt32(Console.ReadLine());

                //Comparison statements; if package dimensions totals over 50, error message will show
                int totalDimensions = packageWidth + packageHeight + packageLength;
                if (totalDimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else //program will end if above "if" is met, else, will continue
                {

                    //multiply the 3 dimensions, finally divide total dimensions by weight
                    int packageProduct = packageWidth * packageHeight * packageLength;
                    int packageTotal = packageProduct * packageWeight / 100;

                    //Display the quote
                    Console.WriteLine("Your estimated total for shipping this package is: $" + packageTotal + ".00");
                    Console.ReadLine();
                }
            }

        }
    }
}
