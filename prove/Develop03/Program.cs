using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a new instance of the Scripture class with the reference "John 3:16" and the text as the scripture passage.
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        // Clear the console.
        Console.Clear();

        // Display the scripture reference and the words of the scripture.
        scripture.Display();

        // Enter a loop that continues until all words in the scripture are revealed or the user types 'quit'.
        while (scripture.HasHiddenWords())
        {
            // Prompt the user to press Enter to continue or type 'quit' to exit.
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            // Read the user's input and convert it to lowercase.
            string input = Console.ReadLine().ToLower();

            // If the user types 'quit', break out of the loop and end the program.
            if (input == "quit")
            {
                break;
            }
            // Clear the console.
            Console.Clear();

            // Hide a random word in the scripture.
            scripture.HideRandomWord();

            // Display the scripture reference and the updated words of the scripture.
            scripture.Display();
        }
    }
}



