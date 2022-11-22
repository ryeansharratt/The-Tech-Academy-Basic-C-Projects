using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Employee
    {
        public int ID { get; set; } //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator== (Employee employee1, Employee employee2) //true/false comparison
        {
            if (employee1.ID == employee2.ID) //if first employee id is same as second employee id, it's true
                return true;
            else
                return false;
            
        }
        public static bool operator!= (Employee employee1, Employee employee2) //have to overload this operator too, (in pairs)
        {
            return employee1.ID != employee2.ID;
        }
        //apparently must also override this Equals(object)?
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        //compiler warning... according to MS this keeps Equals and GetHashCode synchronized?
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
