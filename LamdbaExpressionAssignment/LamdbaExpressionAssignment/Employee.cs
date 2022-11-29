using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdbaExpressionAssignment
{
    class Employee
    {
        public int Id { get; set; } //employee class properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Employee(string firstnames, string lastnames, int ids) //so Employee can take 3 args
        {
            
            FirstName = firstnames;
            LastName = lastnames;
            Id = ids;
        }
    }
}
