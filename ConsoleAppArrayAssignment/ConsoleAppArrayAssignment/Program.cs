using System;
using System.Collections.Generic;



    class Program
    {
        static void Main()
        {

        //initializing a dynamic array during declaration, string values
        string[] namesArray = { "Jaden", "Madyn", "Erin", "Shelby", "Mica", "Eunice", "Brody" };
        Console.WriteLine("Pick a number out of 0-6.");
        int input = int.Parse(Console.ReadLine()); //getting index # from user entered input
        Console.WriteLine("That name is: " + namesArray[input] + "."); //returning result of the name at the index user selected
        Console.ReadLine();

        //initializing an array of integers - ONLY example with an error message if out of bounds
        int[] apartmentNumber = { 102, 104, 106, 115, 123 };
        Console.WriteLine("Pick a number from 0-4.");

        int input2 = int.Parse(Console.ReadLine());
        if (input2 <= 4)
        {
            Console.WriteLine("Congrats! You just won an apartment. The apartment # is: " + apartmentNumber[input2] + ".");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine($"{input2} is out of index range. "); //error message if user inputs anything but 0-4
        }

        Console.ReadLine();


        //list of strings:


        List<string> stringList = new List<string>() //creating a new list of strings
        {
            "Hakuna Matata", "Be our Guest" //the 2 strings
        };
        Console.WriteLine("Pick, 0 or 1?"); //prompt for user
        int userInput = int.Parse(Console.ReadLine()); //taking in user input
        Console.WriteLine("Get ready to sing..."); //output after input
        Console.WriteLine(stringList[userInput]); //result based on input
        Console.ReadLine();
       
        }
    }
