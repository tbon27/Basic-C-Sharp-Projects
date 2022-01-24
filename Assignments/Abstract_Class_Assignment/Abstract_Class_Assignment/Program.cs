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
            Employee employee1 = new Employee(); // instantiate Employee class
            employee1.firstName = "Sample1"; //initialize
            employee1.lastName = "Employee1"; //initialize
            employee1.Id = 1001;
            
            Employee employee2 = new Employee(); // instantiate Employee class
            employee2.firstName = "Sample2"; //initialize
            employee2.lastName = "Employee2"; //initialize
            employee2.Id = 1002;

            Console.WriteLine("Press enter to view employee ID's...");
            Console.ReadLine();
            Console.WriteLine("Employee 1 ID#: " + employee1.Id);
            Console.WriteLine("Employee 2 ID#: " + employee1.Id);

            


            employee1.SayName(); // call superclass method on employee object (Employee inherits Person and override virtual method)
            Console.ReadLine();

            Console.WriteLine("Press enter to call the Quit() method inherited from IQuittable...");
            Console.ReadLine();

            IQuittable iquittable = new Employee(); // use polymorphism to create an object of type IQuittable 
            iquittable.Quit(); // call the Quit() method on new object
            Console.ReadLine();
        }
    }
}
