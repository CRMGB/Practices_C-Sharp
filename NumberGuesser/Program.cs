using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
       public static void Main(string[] args)
        {
            GetAppInfo();//Run the getApp nfo demo
            //ask user name
            GreetUser();

            while (true)
            {
                //init set correct umber
                //int correctNumber = 7;


                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //init gues bar
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    //get a user input 
                    string input = Console.ReadLine();

                    //MAke sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");  
                    }

                    //cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number 
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }

                }
                //Change text color
                PrintColorMessage(ConsoleColor.Yellow, "You are corrct!!!!");
                //get answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        static void GetAppInfo()
        {
            //Set app vars
            string appName = "Number guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Brad Traversy";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info


            Console.WriteLine("{0}: version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }
        static void GreetUser()
        {

            Console.WriteLine("What is your name?");

            //Get user input 
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }
        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //Write out app info


            Console.WriteLine(message);
            Console.ResetColor();

            //keep going 
            continue;
        }
    }
}
