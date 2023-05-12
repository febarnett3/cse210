using System.Collections.Generic;
using System;
namespace Develop02{
    class Prompts{
        // Attributes
        List<string> prompts = new List<string>() {"Tell me, how do you see yourself?", "What did you do today?", "What made you smile today?", "What is the best thing you ate today?", "How do you feel?", "What made you laugh?", "What are you thinking about?", "What's bothering you?", "Who was the most interesting person you interacted with today?", "What was the best part of your day?", "How did you see the hand of the Lord in your life today?", "What was the strongest emotion you felt today?", "If you had one thing you could do over today, what would it be?", "What if any, mistakes or mishaps did you make today?"};
        //Behaviors
        public string GetRandomPrompt()
        {
            Random rnd = new Random();
            int randIndex = rnd.Next(prompts.Count);
            string random = prompts[randIndex];
            return random;
        }

    }
}