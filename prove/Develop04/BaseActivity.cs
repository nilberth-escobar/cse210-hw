using System;
using System.Collections.Generic;
using System.Threading;


// Base class for activities
public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    protected void Countdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

    public Activity(string name, string description)
    {
        this._name = name;
        this._description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Starting {_name} activity...");
        Console.WriteLine(_description);

        SetDuration();
        PrepareToBegin();

        PerformActivity();

        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        Thread.Sleep(3000); // Pause for several seconds
    }

    protected void SetDuration()
    {
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }

    protected void PrepareToBegin()
    {
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for several seconds
        //Countdown(3);
    }

    protected abstract void PerformActivity();
}
