using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>(); //instantiate List of type Employee
            employeeList.Add(new Employee() { fName = "Tony", lName = "Jones", ID = 2 }); //add instance new object with properties fName, lName, and ID to list
            employeeList.Add(new Employee() { fName = "Jennifer", lName = "Johnson", ID = 3 });
            employeeList.Add(new Employee() { fName = "Joe", lName = "Marks", ID = 4 });
            employeeList.Add(new Employee() { fName = "Bennie", lName = "Gates", ID = 5 });
            employeeList.Add(new Employee() { fName = "Francine", lName = "Pence", ID = 6 });
            employeeList.Add(new Employee() { fName = "Serena", lName = "Smith", ID = 7 });
            employeeList.Add(new Employee() { fName = "Ken", lName = "Shaw", ID = 8 });
            employeeList.Add(new Employee() { fName = "Hal", lName = "Ramirez", ID = 9 });
            employeeList.Add(new Employee() { fName = "Harold", lName = "Johnson", ID = 10 });
            employeeList.Add(new Employee() { fName = "Joe", lName = "Garcia", ID = 11 });

            Console.WriteLine("Employee List:");
            foreach (Employee employee in employeeList) // print each employee in employee list
            {
                Console.WriteLine("ID #" + employee.ID + " " + employee.fName + " " + employee.lName);
            }


            //create a new list of all employees with the first name “Joe”
            ////using foreach
            List<Employee> joeList = new List<Employee>(); //create new List of Employee type for joe duplicates to be added to
            foreach(Employee employee in employeeList) 
            {
                if(employee.fName == "Joe") //if employe first name match "Joe"..
                {
                    joeList.Add(employee); //add this employee to the list of employees with first name "Joe"
                }
            }
            Console.ReadLine();
            Console.WriteLine("Press enter to show new list containing all employees with first name \"Joe\"");
            Console.ReadLine();
            Console.WriteLine("Joe List:");
            foreach (Employee employee in joeList) 
            {
                Console.WriteLine("ID #" + employee.ID + " " + employee.fName + " " + employee.lName); //print joeList (2 results)
            }
            Console.ReadLine();

            //using lambda
            List<Employee> newList = employeeList.Where(x => x.fName == "Joe").ToList(); //check employee list where x item's firstName is equal to "Joe", add to list newList
            Console.WriteLine("Joe List (with lambda):");
            foreach(Employee employee in newList)
            {
                Console.WriteLine("ID #" + employee.ID + " " + employee.fName + " " + employee.lName); //print newList from those matching "Joe" firstName/newList
            }
            Console.ReadLine();
            Console.WriteLine("Press enter to show new list containing all employees with ID greater than 5");
            Console.ReadLine();
            // Using a lambda expression, make a list of all employees with an Id number greater than 5
            List<Employee> greater5List = employeeList.Where(x => x.ID > 5).ToList(); //check employee list where x item's ID is greater than 5, add to list greater5List
            Console.WriteLine("Joe List (with lambda):");
            foreach (Employee employee in greater5List)
            {
                Console.WriteLine("ID #" + employee.ID + " " + employee.fName + " " + employee.lName); //print newList from those matching "Joe" firstName/newList
            }
            Console.ReadLine();
        }

    }
}
