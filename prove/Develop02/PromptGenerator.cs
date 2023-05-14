using System;
using System.Collections.Generic;

namespace JournalApp
{
    class PromptGenerator
    {
        public static Prompt GetRandomPrompt()
        {
            List<Prompt> prompts = new List<Prompt>
            {
                new Prompt { Question = "Who was the most interesting person I interacted with today?", Date = DateTime.Now },
                new Prompt { Question = "What was the best part of my day?", Date = DateTime.Now },
                new Prompt { Question = "How did I see the hand of the Lord in my life today?", Date = DateTime.Now },
                new Prompt { Question = "What was the strongest emotion I felt today?", Date = DateTime.Now },
                new Prompt { Question = "If I had one thing I could do over today, what would it be?", Date = DateTime.Now }
            };

            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}
