using System;
using System.Collections.Generic;
using System.Threading;

// Breathing activity
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void PerformActivity()
    {
        int breathCount = _duration / 2;
        for (int i = 0; i < breathCount; i++)
        {
            Countdown(3);
            Console.WriteLine("Breathe in...");
            Thread.Sleep(3);
            
            Thread.Sleep(3500); // Pause for 3.5 seconds
            Countdown(3);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(3);
            
            Thread.Sleep(3500); // Pause for 3.5 seconds
        }
    }
}