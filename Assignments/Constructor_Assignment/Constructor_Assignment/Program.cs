using System;

namespace Constructor_Assignment
{
    class Program 
    {
        static void Main(string[] args)
        {
            const string educationProgram = "The Tech Academy"; //create a constant string as the program, for all students

            Console.WriteLine("Please enter a name:"); 
            string userNameInput = Console.ReadLine(); //take user input as string for name

            var newUser = new Names(userNameInput); // create new intance of Names passing the user name input, and assign to var newUser

            newUser.Age = 23; //omit this for default age of 18

            Console.WriteLine("{0} is {1} years old and is a student at {2}.", newUser.Name, newUser.Age, educationProgram);
            Console.ReadLine();
        }
    }
}
