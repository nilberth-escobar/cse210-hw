/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
    }
}*/

using System;
using System.Collections.Generic;
using System.Threading;

// Main program
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Mindfulness App");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            Activity activity;
            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity(); // Creating an instance of BreathingActivity
                    break;
                case 2:
                    activity = new ReflectionActivity(); // Creating an instance of ReflectionActivity
                    break;
                case 3:
                    activity = new ListingActivity(); // Creating an instance of ListingActivity
                    break;
                case 4:
                    return; // Exiting the program
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    continue;
            }

            Console.WriteLine();
            activity.Start(); // Starting the selected activity
        }
    }
}