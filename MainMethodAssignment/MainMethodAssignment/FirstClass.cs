using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class FirstClass        //methods of same name, but each taking in different parameter type
    {
        public int Math(int first) //takes an integer
        {
            int answer = first + 253; //performs addition
            return answer; //returns answer
        }

        public int Math(decimal num1) //takes decimal
        {
            int answer = (int)(num1 / 4); //divides by 4
            return answer; //return answer as int
        }

        public int Math(string string1) //takes a string
        {
            int num2 = Convert.ToInt32(string1);
            int answer = num2 + 10;
            return (answer); //return answer as int
        }
    }
}
