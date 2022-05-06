using System;

namespace SelectionStatementsConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            //int favoriteNumber = 7;

            //Console.WriteLine("Guess the favorite number. Hint: below 10");
            //int userGuess = int.Parse(Console.ReadLine());

            //if (userGuess < favoriteNumber)
            //{
            //    Console.WriteLine("Too LOW!!!");
            //}
            //else if (userGuess > favoriteNumber)
            //{
            //    Console.WriteLine("Too HIGH!!!");
            //}
            //else if (userGuess == favoriteNumber)
            //{
            //    Console.WriteLine("You were correct, here is a cookie");
            //}
            //else
            //{
            //    Console.WriteLine("Nevermind");
            //}

            string subject = "C#";
            
            Console.WriteLine("Choose a subject");
            string userSubject = Console.ReadLine();

            switch (userSubject)
            {
                case "C#":
                    Console.WriteLine("You are in the right class!");
                    break;
                case "Java":
                    Console.WriteLine("C# is better than Java");
                break;
                default:
                    Console.WriteLine("We teach coding here.");
                    break;
            }
        }
    }
}