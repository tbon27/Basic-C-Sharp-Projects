using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Player newPlayer = new Player("Tony"); //demo- constructor callchain
            //var newPlayer = new Player("Tony"); // var demo- C# figures out data type on the fly

            const string casinoName = "Grand Hotel and Casino";//declaring constant demo - const cannot change

            Console.WriteLine("Welcome to the {0}! Let's start by telling me your name:", casinoName);
            string playerName = Console.ReadLine();

            if(playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.Timestamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }

            bool validAnswer = false;
            int bank = 0;


            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank); //try parse converts the string representation of a number, a return means success (failure then =0)
                if (!validAnswer) Console.WriteLine("Please enter digits only; no decimals."); //if not a valid answer
            }

            //Console.WriteLine("And what is your budget today?");
            //int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if(answer == "yes" || answer == "yess" || answer == "ya" || answer == "yeah" || answer == "yah"|| answer == "yep"||answer == "yup"|| answer == "y"){
                Player player = new Player(playerName, bank); // name and how much they brought
                player.id = Guid.NewGuid(); // GLOBAL UNIQUE IDENTIFIER
                using (StreamWriter file = new StreamWriter(@"C:\Users\tbong\OneDrive\Documents\GitHub\Basic-C-Sharp-Projects\TwentyOne\Logs\log.txt", true)) //false creates new files, this appends
                {
                    file.WriteLine(player.id); // write cards suit and face to text file
                }
                Game game = new TwentyOneGame(); //polymorphism, creating a Game() because we want to expose the overloaded operators
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch(FraudException ex) //more specific exceptions
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return; 
                    }
                    catch (Exception ex) //polymorph; generic exception catches the rest
                    {
                        Console.WriteLine("An error occured, please contact your System Administrator");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to browse the Casino. Bye for now!");
            Console.Read();
        }
        private static void UpdateDbWithException(Exception ex)
        {
            //need connection string to connect to a db
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;
                                        Connect Timeout=30;
                                        Encrypt=False;
                                        TrustServerCertificate=False;
                                        ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";

            //SQL Query String - use parameterized queries to protect
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                (@ExceptionType, @ExceptionMessage, @TimeStamp)"; // values will be substituted, must match types (protection)

            //make sure to close off these using statements for unmanaged code/getting external resources
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar); //add data type parameters
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar); //add data type parameters
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime); //add data type parameters

                //ensure data types of values
                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery(); //INSERT statement is non query
                connection.Close();
            }
        }
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;
                                        Connect Timeout=30;
                                        Encrypt=False;
                                        TrustServerCertificate=False;
                                        ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";

            string queryString = @"Select id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //what happens when SQL connection is established
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.id = Convert.ToInt32(reader["id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.Timestamp = Convert.ToDateTime(reader["Timestamp"]);

                    Exceptions.Add(exception);

                }
                connection.Close();
            }
            return Exceptions;
        }
    }
}
