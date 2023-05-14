using System;
using System.Collections.Generic;

namespace JournalApp
{
    class PromptGenerator
    {
        public static Prompt GetRandomPrompt()
        {
            List<Prompt> prompts = new List<Prompt> //setting up the prompts
            {
                new Prompt { _question = "Who was the most interesting person I interacted with today?", Date = DateTime.Now },
                new Prompt { _question = "What was the best part of my day?", Date = DateTime.Now },
                new Prompt { _question = "How did I see the hand of the Lord in my life today?", Date = DateTime.Now },
                new Prompt { _question = "What was the strongest emotion I felt today?", Date = DateTime.Now },
                new Prompt { _question = "If I had one thing I could do over today, what would it be?", Date = DateTime.Now },
                new Prompt { _question = "What was the most interesting thing that happened to you today?", Date = DateTime.Now },
                new Prompt { _question = "What are you grateful for today?", Date = DateTime.Now},
                new Prompt { _question = "What is something you want to improve about yourself?", Date = DateTime.Now},
                new Prompt { _question = "Write about a time when you overcame a challenge.", Date = DateTime.Now},
                new Prompt { _question = "What is a goal you have for the next week/month/year?", Date = DateTime.Now},
                new Prompt { _question = "Write about a place you've always wanted to visit.", Date = DateTime.Now},
                new Prompt { _question = "What is something that made you laugh today?", Date = DateTime.Now},
                new Prompt { _question = "Describe your ideal day.", Date = DateTime.Now},
                new Prompt { _question = "Write about a meaningful conversation you had recently.", Date = DateTime.Now},
                new Prompt { _question = "What is a book/movie/show that you recently enjoyed?", Date = DateTime.Now},
            };

            //choosing promtps from the list randomly
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}