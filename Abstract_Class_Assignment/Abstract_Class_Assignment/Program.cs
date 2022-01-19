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

            Console.WriteLine("Press enter to call the Quit() method inherited from IQuittable...");
            Console.ReadLine();

            IQuittable iquittable = new Employee(); // use polymorphism to create an object of type IQuittable 
            iquittable.Quit(); // call the Quit() method on new object

            Console.ReadLine();
        }
    }
}
