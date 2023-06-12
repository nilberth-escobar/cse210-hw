using System;
using System.Collections.Generic;
using System.Threading;

// Listing activity
public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        Console.WriteLine(prompts[random.Next(prompts.Count)]);
        Console.WriteLine();

        Thread.Sleep(3000); // Pause for several seconds
        Console.WriteLine("Think about the prompt...");

        Thread.Sleep(5000); // Pause for several seconds
        Countdown(3);
        Console.WriteLine("Start listing items...");

        List<string> items = new List<string>();

            for (int i = 0; i < _duration; i++)
            {
                string item = Console.ReadLine();
                items.Add(item);
            }

        Thread.Sleep(_duration * 1000); // Pause for the specified duration in seconds

        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} items.");
    }
}