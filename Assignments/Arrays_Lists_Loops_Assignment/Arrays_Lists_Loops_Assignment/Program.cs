using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Lists_Loops_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //==========
            //=== Part 1
            //==========
            string[] colorsArray = { "blue", "red", "green", "yellow", "orange", "purple", "pink" }; // create one-dim array of strings

            Console.WriteLine("Please enter some text: ");
            string userInput = Console.ReadLine(); // get user text input (tested with: "_color")

            for (int i = 0; i < colorsArray.Length; i++) // loop through array starting at 0, when i < length of array, adding 1 each iteration..
            {
                colorsArray[i] = colorsArray[i] + userInput; // assign userInput to end of item in array
            }

            for (int j = 0; j < colorsArray.Length; j++) // loop through array starting at 0, when i < length of array, adding 1 each iteration..
            {
                Console.WriteLine("Index " + j + ": " + colorsArray[j]); // print off each string (now new string) in the array on a separate line
            }
            Console.ReadLine();
            Console.WriteLine("Press enter to continue to next part...");
            Console.ReadLine();

            //==========
            //=== Part 2
            //==========
            //=== infinite loop!!!
            //for (int k = 1; k > 0; k++) // infinite because k starting at one adding one each iteration is always k>0 (fix by changing k>0 to [example] k<10)
            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine(colorsArray[k]); // print array line by line
            }
            Console.ReadLine();
            Console.WriteLine("Press enter to continue to next part...");
            Console.ReadLine();

            //==========
            //=== Part 3
            //==========
            //=== use a loop with < operator
            for (int l = 0; l < 6; l++) // does not check index 7 pink, leaves it off the list
            {
                Console.WriteLine(colorsArray[l]);
            }
            Console.ReadLine();

            //=== use a loop with <= operator
            for (int m = 1; m <= 4; m++)
            {
                Console.WriteLine(colorsArray[m]); // result is index 1-4 (but not >= 5)
            }
            Console.ReadLine();
            Console.WriteLine("Press enter to continue to next part...");
            Console.ReadLine();

            //==========
            //=== Part 4
            //==========
            // list of strings with unique items
            List<string> animals = new List<string>();
            animals.Add("lion");
            animals.Add("tiger");
            animals.Add("bear");
            animals.Add("elephant");
            animals.Add("giraffe");
            animals.Add("wolf");
            animals.Add("squirrel");
            animals.Add("deer");
            animals.Add("turkey");
            animals.Add("giraffe");

            //take user input to search through the list
            Console.WriteLine("Enter an animal to search for: ");
            string userInput2 = Console.ReadLine().ToLower();

            //loop through list and display index of list that contains matching text
            //if list does not contain user input, display the message
            foreach (string animal in animals)
            {
                if (animal == userInput2)
                {
                    Console.WriteLine("Animal found: " + animal + " at index: " + animals.IndexOf(animal));
                    break;
                }
                if (!animals.Contains(userInput2)) //if list does not contain user input
                {
                    Console.WriteLine("This list does not contain the animal: " + userInput2);
                    break;
                }
            }
            Console.ReadLine();
            Console.WriteLine("Press enter to continue to next part...");
            Console.ReadLine();

            //==========
            //=== Part 5
            //==========
            //A list of strings that has at least two identical strings in the list. 
            List<string> reptiles = new List<string>();
            reptiles.Add("snake"); //listed twice
            reptiles.Add("alligator");
            reptiles.Add("crocodile"); //listed twice
            reptiles.Add("snake"); //listed twice
            reptiles.Add("lizard");
            reptiles.Add("turtle");
            reptiles.Add("crocodile"); //listed twice

            //Ask the user to select text to search for in the list.
            Console.WriteLine("Enter a reptile to search for: ");
            string userInput3 = Console.ReadLine(); // take user input to use for loop through list

            //Create a loop that iterates through the list and then displays the indices of the items matching the user - selected text.
            for (int o = 0; o < reptiles.Count; o++)
            {
                if (reptiles[o] == userInput3) // if list item in reptiles at o is equal to user input (example "snake")
                {
                    Console.WriteLine("Reptile found: " + reptiles[o] + " at index: " + o.ToString()); // (example "snake") this displays snake at index 0 and again at 3
                }
                if (!reptiles.Contains(userInput3)) //if list does not contain user input
                {
                    Console.WriteLine("This list does not contain the reptile: " + userInput3);
                    break;
                }
            }

            Console.ReadLine();
            Console.WriteLine("Press enter to continue to next part...");
            Console.ReadLine();

            //Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.


            //==========
            //=== Part 6
            //==========
            //Create a list of strings that has at least two identical strings in the list.
            List<string> names = new List<string>();            
            List<string> duplicateList = new List<string>(); // new list to store list items that have been iterated through
            names.Add("bob"); //listed thrice
            names.Add("john");
            names.Add("mary"); //listed twice
            names.Add("tim");
            names.Add("sharon");
            names.Add("bob"); //listed thrice
            names.Add("thomas");
            names.Add("mary"); //listed twice
            names.Add("jennifer");
            names.Add("bob"); //listed thrice

            //Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            foreach (string name in names)
            {      
                //Console.WriteLine(name);  //display list of names
                if (!duplicateList.Contains(name))
                {
                    duplicateList.Add(name); // add this name to duplicate list if duplicate list does not contain already
                    Console.WriteLine(name + " has not appeared in this list...");
                }
                else // if name is already on duplicate list
                {
                    Console.WriteLine(name + " has appeared in this list.");
                }
                
            }
            Console.ReadLine();
        }
    }
}
