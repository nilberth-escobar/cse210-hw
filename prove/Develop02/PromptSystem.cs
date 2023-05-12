using System;

public class RandomPromptSystem {
    private string[] prompts;
    private Random rand;

    public RandomPromptSystem() {
        prompts = new string[] {
            "What was the most interesting thing that happened to you today?",
            "What are you grateful for today?",
            "What is something you want to improve about yourself?",
            "Write about a time when you overcame a challenge.",
            "What is a goal you have for the next week/month/year?",
            "Write about a place you've always wanted to visit.",
            "What is something that made you laugh today?",
            "Describe your ideal day.",
            "Write about a meaningful conversation you had recently.",
            "What is a book/movie/show that you recently enjoyed?",
        };
        rand = new Random();
    }

    public void Display() {
        Console.WriteLine(GetPrompt());
    }

    public string GetPrompt() {
        return prompts[rand.Next(prompts.Length)];
    }
}
