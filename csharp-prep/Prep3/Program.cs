using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prep3");

        int guessNumber = 18;

        Console.WriteLine("Welcome to Guess the number");

        //asking the user to enter the number

        //int userNumber = 0;
        string userAnswer = "";

        while (userAnswer.ToLower() != "no")
        {
            Console.WriteLine("Enter your guessing number:");

            int Number = int.Parse(Console.ReadLine());

            if (Number > guessNumber)
            {
                Console.WriteLine("Guess a lower number...");
            }

            else if (Number < guessNumber)
            {
                Console.WriteLine("Guess a higher number...");
            }

            else
            {
                Console.WriteLine("You got it");

                
            }

            Console.WriteLine("\nWould you like to keep playing?");
            userAnswer = Console.ReadLine();
            
        }

    }
}