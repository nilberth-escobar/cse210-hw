using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prep3");

        //int guessNumber = 18;

        Console.WriteLine("\nWelcome to Guess the number");
        Console.WriteLine("\nThe number you have to guess is generated automatically");

        Random randomNumber = new Random();
        int computerNumber = randomNumber.Next(1, 101);

        
        //int userNumber = 0;

        //string variable that saves the user answers if keep playing
        string userAnswer = "";

        while (userAnswer.ToLower() != "no")
        {
            //asking the user to enter the number
            Console.WriteLine("\nEnter your guessing number:");

            int Number = int.Parse(Console.ReadLine());

            if (Number > computerNumber)
            {
                Console.WriteLine("Guess a lower number...");
            }

            else if (Number < computerNumber)
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