using System;
using System.Collections.Generic;
using System.Threading;


// Base class for activities
public abstract class Activity
{
    protected string _name; // Attribute to store the name of the activity
    protected string _description; // Attribute to store the description of the activity
    protected int _duration; // Attribute to store the duration of the activity

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
        this._name = name; // Setting the name attribute with the provided value
        this._description = description; // Setting the description attribute with the provided value
    }

    public void Start()
    {
        Console.WriteLine($"Starting {_name} activity...");
        Console.WriteLine(_description);

        SetDuration(); // Calling the SetDuration method to set the duration for the activity
        PrepareToBegin(); // Calling the PrepareToBegin method to prepare for the activity

        PerformActivity(); // Calling the PerformActivity method specific to each activity

        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        Thread.Sleep(3000); // Pause for several seconds
    }

    protected void SetDuration()
    {
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine()); // Setting the duration attribute with the provided value
    }

    protected void PrepareToBegin()
    {
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for several seconds
    }

    protected abstract void PerformActivity(); // Abstract method to be implemented by the specific activities
}
