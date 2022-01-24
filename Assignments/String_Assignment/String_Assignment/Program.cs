using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // #1. Concatenate 3 strings
                string fName = "Anthony";
                string mInitial = "R";
                string lName = "Bongiovanni";

                string resultStr = ("My first name is " + fName + ".\nMy middle initial is " + mInitial + ".\nMy last name is " + lName + ".");
                Console.WriteLine(resultStr);
                Console.WriteLine(fName + " " + mInitial + ". " + lName);
                Console.WriteLine("Press Enter to continue to exercise #2");
                Console.ReadLine();

                // #2. Convert String to Upper case
                string name1 = "tony";
                Console.WriteLine("My name in lower case is " + name1 +".");
                name1 = name1.ToUpper();
                Console.WriteLine("My name in upper case is " +name1);
                Console.WriteLine("Press Enter to continue to exercise #3");
                Console.ReadLine();

                // #3. String builder paragraph of text one sentence at a time
                StringBuilder sb = new StringBuilder();
                string name = "Anthony";
                sb.Append("Hi! My name is " + name + ".");
                name = "Tony";
                sb.Append("\nAlthough I prefer to be called " + name + ".\nI am a student at The Tech Academy." + "\nThis is a sentence for my paragraph in this assignment." + "\nThis is another sentence for my paragraph in this assignment..." +  "\nI think this is probably enough paragraphs.");

                Console.WriteLine(sb);
                Console.ReadLine();
            }
        }
    }
}
