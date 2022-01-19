using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    class Employee : Person, IQuittable // inherit from person class
    {
        public override void SayName() // override the virtual method within abstract class
        {
            base.SayName(); // get from virtual method in Person abstract class
        }

        public void Quit() // implement method from interface IQuittable
        {
            Console.WriteLine("This is the Quit() method!");
        }
    }
}
