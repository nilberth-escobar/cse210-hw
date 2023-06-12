using System;
using System.Collections.Generic;
using System.Threading;

// Reflection activity
public class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>()
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

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        int questionCount = _duration / 5;
        for (int i = 0; i < questionCount; i++)
        {
            Console.WriteLine(prompts[random.Next(prompts.Count)]);
            Console.WriteLine();

            foreach (string question in GetRandomQuestions())
            {
                Console.WriteLine(question);
                Countdown(3);
                Thread.Sleep(10000); // Pause for several seconds
            }

            Console.WriteLine();
        }
    }

    private List<string> GetRandomQuestions()
    {
        ShuffleQuestions();
        return questions.GetRange(0, 3);
    }

    private void ShuffleQuestions()
    {
        Random random = new Random();
        int n = questions.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            string value = questions[k];
            questions[k] = questions[n];
            questions[n] = value;
        }
    }
}
