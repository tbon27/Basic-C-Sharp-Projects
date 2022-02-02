﻿using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your first name.");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}.";
            Console.WriteLine(msg);

            string path = @"C:\Users\tbong\OneDrive\Documents\GitHub\Basic-C-Sharp-Projects\Basic_Demos\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path); //grab file from path, store in array
            double totalScore = 0.0;

            Console.WriteLine("\nStudent Score: \n");
            foreach(string line in lines)
            {
                Console.WriteLine("\n" + line);
                double score = Convert.ToDouble(line);
                totalScore += score;
            }
            double averageScore = totalScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " student scores. \tAverage score: " + averageScore);
            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadLine();
        }
    }
}
