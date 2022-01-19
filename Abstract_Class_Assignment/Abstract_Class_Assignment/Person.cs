using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    public abstract class Person // create abstract class - not to be an object ever, inherit from
    {
        // properties
        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual void SayName() // make virtual so it can be accessed outside abstract class
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }
    }
}
