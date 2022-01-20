using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    public abstract class Person // create abstract class - not to be an object ever, inherit from
    {
        // properties
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int id { get; set; }

        public virtual void SayName() // make virtual so it can be accessed outside abstract class
        {
            Console.WriteLine("Name: {0} {1}, ID#: {2}", firstName, lastName, id);
        }        
        
    }
}
