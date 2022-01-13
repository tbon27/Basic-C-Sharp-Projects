using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //=== Iteration PART 1
            ////Looping through int array
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for(int i = 0; i < testScores.Length; i++)
            //{
            //    if(testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            ////Looping through string array
            //string[] names = { "Tony", "Rachel", "Wyatt", "Everett" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine(names[j]); //print list of all in array
            //    if (names[j] == "Rachel")
            //    {
            //        Console.WriteLine(names[j]); //print again as the array hits this index
            //    }
            //}
            //Console.ReadLine();

            //=== Iteration PART 2 - Lists
            //// INT LIST
            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(85);
            //testScores.Add(70);
            //testScores.Add(82);
            //testScores.Add(34);
            //testScores.Add(91);
            //testScores.Add(90);
            //testScores.Add(94);

            //foreach(int score in testScores)
            //{
            //    if(score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}
            //Console.ReadLine();            

            //// STRING LIST
            //List<string> names = new List<string>();
            //names.Add("Tony");
            //names.Add("Rachel");
            //names.Add("Wyatt");
            //names.Add("Everett");

            //foreach(string name in names)
            //{
            //    Console.WriteLine(name); // display all names in array with loop picking out "Rachel" and printing again
            //    if(name == "Rachel")
            //    {
            //        Console.WriteLine("Name: " + name);
            //    }
            //}
            //Console.ReadLine();

            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if(score > 85)
                {
                    passingScores.Add(score);
                }
            }

            Console.WriteLine("Passing Scores: " + passingScores.Count);
            Console.ReadLine();

        }
    }
}
