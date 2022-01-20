using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{ 
    class Employee : Person // inherit from person class
    {
        public override void SayName() // override the virtual method within abstract class
        {
            base.SayName(); // get from virtual method in Person abstract class
        }

        //==========================
        //==  Overload "==" operator
        //==========================
        public static bool operator== (Employee employee1id, Employee employee2id) // overload operator == (bool), take 2 operands as Employee type
        {
            return employee1id.id == employee2id.id; // use id property from Employee in equality expression, returning a true or false 
        }       
        public static bool operator!= (Employee employee1id, Employee employee2id)
        {
            return employee1id.id != employee2id.id;  // use id property from Employee in equality expression, returning a true or false 
        }

        // 2 issues: 
        // 1.)  CS0660	'Employee' defines operator == or operator != but does not override Object.Equals(object o)
        // 2.)  CS0661	'Employee' defines operator == or operator != but does not override Object.GetHashCode()
        // resolved.
        // Following solution from docs.microsoft
        public override bool Equals(object o)
        {
            return true;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}
