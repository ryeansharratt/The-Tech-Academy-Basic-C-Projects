using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("What is my age?"); //question asked
            int ageGuess = Convert.ToInt32(Console.ReadLine()); //user input given var ageGuess
            bool myAge = ageGuess == 20; //boolean comparison against user input. Is "true" if user inputs "20"


            //WHILE LOOP BOOLEAN COMPARISON


            //while (!myAge)                                    //commented out to work on blocks seperately
            //{
            //    switch (ageGuess)
            //    {

            //      case 50: //did this happen? If yes, program writes back with:
            //          Console.WriteLine("Hah. Funny.");
            //          Console.WriteLine("What is my age?");
            //          ageGuess = Convert.ToInt32(Console.ReadLine());
            //          break;
            //      case 20: //this is the true case, but if guessed right (because this isn't "do"), the program ends immediately
            //          Console.WriteLine("You guessed right!");
            //          myAge = true;
            //          break;
            //      default: //if neither above is true, program writes below back, and program keeps looping
            //          Console.WriteLine("You're wrong.");
            //          Console.WriteLine("What is my age?");
            //          ageGuess = Convert.ToInt32(Console.ReadLine());
            //          break;

            //    }        
            //}



            //DO WHILE LOOP BOOLEAN COMPARISON



            do //so that even if first guess is right, the while loop will happen at least once
            {
                switch (ageGuess)
                {

                    case 50:
                        Console.WriteLine("Hah. Funny.");
                        Console.WriteLine("What is my age?");
                        ageGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 20: //because of "do" program hits while loop even if guessed correctly the first time. Will then input this:
                        Console.WriteLine("You guessed right!");
                        myAge = true; //this is the true case
                        break;
                    default: //keeps looping if neither above are guessed
                        Console.WriteLine("You're wrong.");
                        Console.WriteLine("What is my age?");
                        ageGuess = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }

            while (!myAge);

            Console.ReadLine();

        }
    }  
}      

