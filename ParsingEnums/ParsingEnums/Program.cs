using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {

        public enum WeekDay //enum
        {
            Sunday = 1,
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
            Thursday = 5,
            Friday = 6,
            Saturday = 7
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week: "); //user input
            string value = Console.ReadLine();

            WeekDay day;
            try         //try/catch, if input(value) matches proper day of the week in enum, it's good!
            {
                day = (WeekDay)Enum.Parse(typeof(WeekDay), value);
            }
            catch (Exception ex) //if not input correctly, error message is shown
            {
                Console.WriteLine("Sorry please type an actual day of the week.");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}