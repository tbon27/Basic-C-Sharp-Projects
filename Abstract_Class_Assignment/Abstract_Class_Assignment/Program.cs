using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // instantiate Employee class
            employee.firstName = "Sample"; //initialize
            employee.lastName = "Student"; //initialize

            employee.SayName(); // call superclass method on employee object (Employee inherits Person and override virtual method)
            Console.ReadLine();
        }
    }
}
