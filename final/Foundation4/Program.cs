/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
    }
}*/

using System;
using System.Collections.Generic;

class Activity
{
    public DateTime Date { get; set; }
    public int LengthInMinutes { get; set; }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Unknown Activity ({LengthInMinutes} min)";
    }
}

class Running : Activity
{
    public double Distance { get; set; }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance / LengthInMinutes * 60;
    }

    public override double GetPace()
    {
        return LengthInMinutes / Distance;
    }

    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Running ({LengthInMinutes} min) - Distance: {Distance:F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}

class Cycling : Activity
{
    public double Speed { get; set; }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }

    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Cycling ({LengthInMinutes} min) - Speed: {Speed:F1} mph, Pace: {GetPace():F1} min per mile";
    }
}

class Swimming : Activity
{
    public int Laps { get; set; }

    public override double GetDistance()
    {
        return Laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / LengthInMinutes * 60;
    }

    public override double GetPace()
    {
        return LengthInMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Swimming ({LengthInMinutes} min) - Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running runningActivity = new Running()
        {
            Date = new DateTime(2022, 11, 3),
            LengthInMinutes = 30,
            Distance = 3.0
        };
        activities.Add(runningActivity);

        Cycling cyclingActivity = new Cycling()
        {
            Date = new DateTime(2022, 11, 3),
            LengthInMinutes = 30,
            Speed = 6.0
        };
        activities.Add(cyclingActivity);

        Swimming swimmingActivity = new Swimming()
        {
            Date = new DateTime(2022, 11, 3),
            LengthInMinutes = 30,
            Laps = 80
        };
        activities.Add(swimmingActivity);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
