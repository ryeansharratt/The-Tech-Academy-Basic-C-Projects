using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment1
{
    public class MathOperation //these methods will take one number, and each operate on it together, one after the other
                                //also int, so results will not be precise
    {
        public int Addition(int input) //defined method, 1 integer parameter of user's input
        {
            int result = input + 10; //addition, calculating result and storing in variable
            return (result); //returning result to main program, to be returned again for next method...
        }

        public int Division(int input)
        {
            int result = input / 3; //division
            return (result);
        }

        public int Multiply(int input)
        {
            return input * 2; //multiplication
        }
    }
}
