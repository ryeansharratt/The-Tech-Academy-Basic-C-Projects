using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public abstract class Person //abstract class
    {
        public string firstName { get; set; } //two string properties
        public string lastName { get; set; }

        public virtual void SayName() //SayName method, virtual means that this method gets inherited, has ability to override
        {
            Console.WriteLine("Name : " + firstName + " " + lastName);
            Console.ReadLine();
        }
    }
}
