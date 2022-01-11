using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //// using escapes for quotes, and \n new line
            //string name = "Tony";
            //string quote = "\nThe man said, \"Hello\"!\nNice to meet you...";
            //Console.WriteLine(name + " " + quote);

            //string fileName = @"C:\Users\Tony"; // this is used to say the backslashes are part of the directory location listed
            //Console.WriteLine(fileName);

            //// examples of built in methods
            //bool trueOrFalse = name.Contains("t");
            //trueOrFalse = name.EndsWith("y");
            //Console.WriteLine(trueOrFalse);

            //int length = name.Length; // number of characters in variable name (ex: tony = 4)
            //Console.WriteLine(length);

            //name = name.ToUpper();
            //Console.WriteLine(name);

            //Console.ReadLine();

            // String builder demo - used to limit memory overhead when overwriting strings
            StringBuilder sb = new StringBuilder();
            string name = "Anthony";
            sb.Append("My name is " + name +"\n");
            name = "Tony";
            sb.Append("My name is " + name);

            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
