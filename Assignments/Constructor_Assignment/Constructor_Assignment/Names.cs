using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    public class Names
    {
        // Constructor chaining, constructor callchain
        public Names(string name) : this(name, 18) //assign name to name, and default age 18
        { } //no need for implementation here, we are reusing the constructor below, in this constructor

        public Names(string name, int age) //constructor taking two params
        {
            Name = name;
            Age = age;
        }

        //set properties
        public string Name { get; set; } 
        public int Age { get; set; }
    }
}
