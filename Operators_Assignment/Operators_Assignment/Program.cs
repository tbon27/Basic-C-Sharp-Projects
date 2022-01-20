using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> loginCred = new Employee<string>();
            loginCred.things = new List<string>();
            loginCred.things.Add("username: fjones0");
            loginCred.things.Add("password");
            loginCred.things.Add("access level 2");

            Employee<int> intData = new Employee<int>();
            intData.things = new List<int>();
            intData.things.Add(2300);
            intData.things.Add(4588);
            intData.things.Add(8080);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(loginCred.things[i]);
                Console.WriteLine(intData.things[i]);
            }
            Console.ReadLine();
/*
            Employee employee = new Employee(); // instantiate Employee class
            employee.firstName = "Janice"; // initialize
            employee.lastName = "Johnson"; // initialize
            employee.id = 1001; // initialize employee1 id int value
                                           
            Employee employee2 = new Employee(); // instantiate Employee class
            employee2.firstName = "Edgar"; // initialize
            employee2.lastName = "Rawlings"; // initialize
            //employee2.id = 1001; // initialize employee2 id int value
            employee2.id = 1005; // test value

            Console.WriteLine("Employee List: ");
            employee.SayName(); // call superclass method on employee object (Employee inherits Person and override virtual method)
            employee2.SayName(); // call superclass method on employee object (Employee inherits Person and override virtual method)
            Console.ReadLine();



            //==  Overload "==" operator
            //==========================
            // here we use our overload comparing Employee objects employee and employee2...
            // ...resulting in employee1id.id == employee2id.id (TRUE/FALSE)            
            Console.WriteLine("Employee Id's Match: " + (employee == employee2));

            // And (opposite as above) != overloaded.. employee1id.id != employee2id.id (FALSE)
            Console.WriteLine("Employee Id's Don't Match: " + (employee != employee2));

            Console.ReadLine();
*/
        }
    }
}
