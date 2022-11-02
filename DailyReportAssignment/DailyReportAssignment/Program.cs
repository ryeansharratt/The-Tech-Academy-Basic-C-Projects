using System;

    class Program
    {
        static void Main()
        {

        Console.WriteLine("Academy of Learning Career College \nStudent Daily Report"); //all Console.WriteLine 's are giving the phrase inputted by developer 
        
         //upon execution, goes right into the first question:

        Console.WriteLine("What is your name?");
        string yourName = Console.ReadLine();       //Data type is "string"... all readline's are the space for user to input data

        Console.WriteLine("What course are you on?");
        string yourCourse = Console.ReadLine();

        Console.WriteLine("What page number?");
        int pageNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
        bool help = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Were there any positive experiences you'd like to share? Please be specific.");
        string positiveExperiences = Console.ReadLine();

        Console.WriteLine("Is there any feedback you'd like to provide? Please be specific.");
        string feedback = Console.ReadLine();

        Console.WriteLine("How many hours did you study today?");
        int hoursStudied = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a wonderful day!");
        Console.ReadLine();

    }
    }    // end of program
