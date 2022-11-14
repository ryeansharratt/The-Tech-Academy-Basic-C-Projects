using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {

        //ASSIGNMENT PART 1

        //One-dimensional string array
        string[] townNames = { "Rocky Mtn. House", "Red Deer", "Canmore", "Nordegg" };
        Console.WriteLine("Please input some text, anything!:"); //asking user to input text
        string input = Console.ReadLine();
        //1st loop that iterates, adds user input to end of each string, doesn't output to console yet
        for (int i = 0; i < townNames.Length; i++) //for loop because wanting to update values in array
        {
            townNames[i] = townNames[i] + " " + input; //appending user data to string in array            
        }
        ////2nd loop that prints each string
        foreach (string name in townNames)
        {
            Console.WriteLine(name);
        }

        Console.ReadLine();

        //ASSIGNMENT PART 2

        //infinite loop:

        //for (int i = 0; i < townNames.Length; i--) //value of i will never be above array length, and i decrements after each iteration
        //{
        //    Console.WriteLine("Value : {0}", i);
        //}
        //Console.ReadLine();

        //infinite loop fix:

        for (int i = 0; i < townNames.Length; i++) //i increments now, i < townNames.Length will only be true until i increments to top number of indices (3)
        {
            Console.WriteLine("Value : {0}", i);
        }
        Console.ReadLine();

        //ASSIGNMENT PART 3

        //loop with < comparison operator:
        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine(i + " ");
        }
        Console.ReadLine();

        //<= comparison operator:
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i + " ");
        }
        Console.ReadLine();

        //ASSIGNMENT PART 4

            List<string> uniqueThings = new List<string>() { "Crystal", "Spatula", "Vancouver", "Bear" }; //list of strings
            Console.WriteLine("Input text to search for..."); //user input text to search for
            string userSearch = Console.ReadLine();

            for (int u = 0; u < uniqueThings.Count; u++)
            {
                if (uniqueThings[u] == userSearch) //if item on list is same as user input //exception handle.. if user input is null
                {
                    Console.WriteLine("Found at index " + u + ".");
                    Console.ReadLine();
                    break; //stops loop when match found
                }
                else if (userSearch == "")
                {
                    Console.WriteLine("Oops");
                    Console.ReadLine();
                }
                else //if user input isn't on list                          //NEED TO FIX THIS...GETTING LOOP TO BREAK WHEN MATCH FOUND, NOT HAVE TO PRINT EACH ARRAY LOOP first?
                {
                    Console.WriteLine("That isn't on the list:/");
                    Console.ReadLine();
                }
            }


        //ASSIGNMENT PART 5


        List<string> fruitColors = new List<string>()
            {
                "Orange", "Pink", "Yellow", "Orange", "Lime"  //list of strings with at least two identical items
            };
        Console.WriteLine("Search for 'Blue', 'Orange', or 'Green'..."); //user asked to input
        string userInput = Console.ReadLine();

        for (int f = 0; f < fruitColors.Count; f++)      //loop to iterate list and display indices of matching text
        {
            if (fruitColors[f] == userInput) //if item on list matches user input
            {
                Console.WriteLine("Found at index(es): " + f + ".");
            }
            else //if user input isn't found
            {
                Console.WriteLine(userInput + " is not on the list.");
            }
        }
        Console.ReadLine();

        //ASSIGNMENT PART 6

        //list of strings, at least two identical strings in list
        List<string> weatherReports = new List<string>()
        {
            "cloudy", "sunny", "sun and clouds", "sunny", "rainy", "cloudy",
        };
        List<string> matchingReports = new List<string>(); //empty list
        Console.WriteLine("Part 6");
        Console.ReadLine();
        foreach (string report in weatherReports) //do values in 1st list exist in 2nd empty list?
        {
            if (!matchingReports.Contains(report)) //if item doesn't exist in 2nd list, it is unique
            {
                matchingReports.Add(report);
                Console.WriteLine("This is unique.");
                Console.ReadLine();
            }
            else if (matchingReports.Contains(report)) //if item does exist already, 2nd instance is a duplicate
            {
                Console.WriteLine("This is a duplicate.");
                Console.ReadLine();
            }
        }
    }
}


