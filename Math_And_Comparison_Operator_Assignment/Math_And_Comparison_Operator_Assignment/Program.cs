using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_And_Comparison_Operator_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter your hourly rate: ");
            string userRate = Console.ReadLine(); //take in user input as string to create the user hourly rate str variable
            decimal hourlyRate = Convert.ToDecimal(userRate); //convert the str to decimal to represent the users actual decimal hourly rate
            Console.WriteLine("Please enter your hours worked per week: ");
            string userHours = Console.ReadLine(); //take in user input as string to create the user hours per week str variable
            int hoursPerWeek = Convert.ToInt32(userHours); //convert the str to int to represent the users actual hours worked per week



            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter your hourly rate: "); //take in user input as string to create the user hourly rate str variable
            string userRate2 = Console.ReadLine(); //take in user input as string to create the user hourly rate str variable
            decimal hourlyRate2 = Convert.ToDecimal(userRate2); //convert the str to decimal to represent the users actual decimal hourly rate
            Console.WriteLine("Please enter your hours worked per week: "); //convert the str to decimal to represent the users actual decimal hourly rate
            string userHours2 = Console.ReadLine(); //take in user input as string to create the user hours per week str variable
            int hoursPerWeek2 = Convert.ToInt32(userHours2); //convert the str to int to represent the users actual hours worked per week



            // calculate and display annual salary for PERSON 1
            Console.WriteLine("Annual Salary of Person 1: ");
            // 52 weeks in a year
            decimal weeklyPay = hourlyRate * hoursPerWeek; //using decimal for money
            weeklyPay = decimal.Round(weeklyPay, 2); // in case the user enters values resulting in a decimals, this will limit to 2 decimal places
            decimal annualPay = weeklyPay * 52;
            annualPay = decimal.Round(annualPay, 2); // in case the user enters values resulting in a decimals, this will limit to 2 decimal places
            Console.WriteLine(annualPay); //display total annual pay


            // calculate and display annual salary for PERSON 2
            Console.WriteLine("Annual Salary of Person 2: ");
            // 52 weeks in a year
            decimal weeklyPay2 = hourlyRate2 * hoursPerWeek2; //using decimal for money
            weeklyPay2 = decimal.Round(weeklyPay2, 2); // in case the user enters values resulting in a decimals, this will limit to 2 decimal places
            decimal annualPay2 = weeklyPay2 * 52;
            annualPay2 = decimal.Round(annualPay2, 2); // in case the user enters values resulting in a decimals, this will limit to 2 decimal places
            Console.WriteLine(annualPay2); //display total annual pay

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            if(annualPay > annualPay2) // compare annual salaries and display the appropriate message
            {
                Console.WriteLine("True");
            }
            else if(annualPay < annualPay2)
            {
                Console.WriteLine("False");
            }
            else{
                Console.WriteLine("They make exactly the same amount of money.");
            }
        }
    }
}
