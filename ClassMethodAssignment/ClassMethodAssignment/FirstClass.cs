using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
        class FirstClass
    {
        public void Math(int num1)
        {
            int result = num1 / 2; //takes user input, divides by 2
            Console.WriteLine(result); //outputs integer
            Console.ReadLine();
        }

        public void Math(out int num2, out int num3) //output parameters, also overloading a method
        {
            num2 = 20; //will output these numbers when variable values are called in main()
            num3 = 12;
            Console.WriteLine("Num2 is {0}", num2);
            Console.WriteLine("Num3 is {0}", num3);
        }
    }
}
