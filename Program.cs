using System;

namespace Number_Guesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string appname = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Ben";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appname, appVersion, appAuthor);

            Console.ResetColor();

            Console.WriteLine("what is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("hello {0}, let's play a game...", inputName);

            Random random = new Random();

            int correctNumber = random.Next(1, 10);

            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            while (guess != correctNumber) {

                string input = Console.ReadLine();

                if(int.TryParse(input, out guess)) {

                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("that is not a number");

                    Console.ResetColor();

                    continue;
                }

                guess = Int32.Parse(input);

                if (guess != correctNumber) { 

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("wrong number please try again");

                Console.ResetColor();

            }
            


            }
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("you are correct");

            Console.ResetColor();
        }
    }
}
