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

namespace MindfulnessApp
{
    public abstract class Activity
    {
        protected string name;
        protected string description;
        protected int duration;

        public Activity(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public void Start()
        {
            Console.WriteLine($"Starting {name} activity...");
            Console.WriteLine(description);
            Console.Write("Enter duration (in seconds): ");
            duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Prepare to begin...");
            Thread.Sleep(3000);
            Console.WriteLine("Starting in:");
            Countdown(3);
            PerformActivity();
            Console.WriteLine($"You have completed the {name} activity for {duration} seconds.");
            Console.WriteLine("Well done!");
            Thread.Sleep(3000);
        }

        protected abstract void PerformActivity();

        protected void Countdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }

    public class BreathingActivity : Activity
    {
        public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }

        protected override void PerformActivity()
        {
            for (int i = 0; i < duration; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Breathe in...");
                }
                else
                {
                    Console.WriteLine("Breathe out...");
                }
                Thread.Sleep(3000);
                Countdown(3);
            }
        }
    }

    public class ReflectionActivity : Activity
    {
        private List<string> prompts;
        private List<string> questions;

        public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
        {
            prompts = new List<string>
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

            questions = new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };
        }

        protected override void PerformActivity()
        {
            Random random = new Random();
            int promptIndex = random.Next(prompts.Count);

            Console.WriteLine(prompts[promptIndex]);

            foreach (string question in GetRandomQuestions())
            {
                Console.WriteLine(question);
                Thread.Sleep(3000);
                Countdown(3);
            }
        }

        private IEnumerable<string> GetRandomQuestions()
        {
            Random random = new Random();
            List<string> remainingQuestions = new List<string>(questions);

            while (remainingQuestions.Count > 0)
            {
                int index = random.Next(remainingQuestions.Count);
                yield return remainingQuestions[index];
                remainingQuestions.RemoveAt(index);
            }
        }
    }

    public class ListingActivity : Activity
    {
        private List<string> prompts;

        public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
            prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };
        }

        protected override void PerformActivity()
        {
            Random random = new Random();
            int promptIndex = random.Next(prompts.Count);

            Console.WriteLine(prompts[promptIndex]);
            Console.WriteLine("Start listing...");

            Thread.Sleep(3000);
            Countdown(3);

            List<string> items = new List<string>();

            for (int i = 0; i < duration; i++)
            {
                string item = Console.ReadLine();
                items.Add(item);
            }

            Console.WriteLine($"You listed {items.Count} items.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Mindfulness App");

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Choose an activity:");
                Console.WriteLine("1. Breathing");
                Console.WriteLine("2. Reflection");
                Console.WriteLine("3. Listing");
                Console.WriteLine("4. Quit");

                int choice = int.Parse(Console.ReadLine());

                Activity activity;

                switch (choice)
                {
                    case 1:
                        activity = new BreathingActivity();
                        activity.Start();
                        break;
                    case 2:
                        activity = new ReflectionActivity();
                        activity.Start();
                        break;
                    case 3:
                        activity = new ListingActivity();
                        activity.Start();
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
