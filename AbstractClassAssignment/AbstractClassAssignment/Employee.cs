using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Employee : Person
    { //implement SayName in this class...

        public override void SayName()
        {
            Console.WriteLine("Full name: ");
            base.SayName();
        }
    }
}
