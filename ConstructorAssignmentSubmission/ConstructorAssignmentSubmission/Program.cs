using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Ryean"; //constant variable
            Console.WriteLine("My name will always be {0}.", myName);
            var hisName = "Jaden"; //variable using keyword var
            Console.WriteLine(hisName);
            Console.ReadLine();

            Person x = new Person("Jaden"); //new Person object, assigning a name, not age though...
            Console.WriteLine($"Name is: {x.Name}, they are at least this old: {x.Age}."); //will take default age because no age is assigned
            Console.ReadLine();

            


        }
    }
}
