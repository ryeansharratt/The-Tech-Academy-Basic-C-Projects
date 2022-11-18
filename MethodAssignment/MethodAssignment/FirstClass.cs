using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class FirstClass
    {
        public int Math(int num1, int num2 = 2) //method, 2 int parameters, 1 optional
        {
            return num1 + num2; //math operation, returns int result
        }
    }
}
