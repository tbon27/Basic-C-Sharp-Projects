using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            //try catch block
            try
            {
                Console.WriteLine("Pick a number!");
                double numberOne = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Pick a second number!");
                double numberTwo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Divide the two...");
                double numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne+" divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch(FormatException ex) 
            {
                Console.WriteLine("Error Message: " + ex.Message + " \nSimply put... type a number!"); //could also add your own message
                return;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Error Message: " + ex.Message + " \nSimply put... don't divide by 0!"); //results in infinity? not divide by zero error
            }            
            catch(Exception ex)
            {
                Console.WriteLine("Error Message: " + ex.Message); 
            }
            finally // used when exception is caught but you want to keep going
            {
                Console.ReadLine();
            }
         
        }
    }
}
