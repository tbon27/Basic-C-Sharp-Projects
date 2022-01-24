using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // instantiate Employee class
            employee.FirstName = "Sample"; //initialize
            employee.LastName = "Student"; //initialize

            employee.SayName(); // call superclass method on employee object (Employee inherits Person)
            Console.ReadLine();
        }
    }
}
