using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstClass firstClass = new FirstClass(); //instantiate class

            firstClass.Math(20, 23); //call method, pass in two numbers
            firstClass.Math(num1: 20, num2: 23); //call method, specify pars
        }
    }
}
