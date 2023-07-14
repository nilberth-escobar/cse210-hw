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


class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running runningActivity = new Running()
        {
            Date = new DateTime(2022, 11, 3),
            LengthInMinutes = 30,
            _distance = 3.0
        };
        activities.Add(runningActivity);

        Cycling cyclingActivity = new Cycling()
        {
            Date = new DateTime(2022, 11, 3),
            LengthInMinutes = 30,
            _speed = 6.0
        };
        activities.Add(cyclingActivity);

        Swimming swimmingActivity = new Swimming()
        {
            Date = new DateTime(2022, 11, 3),
            LengthInMinutes = 30,
            _laps = 80
        };
        activities.Add(swimmingActivity);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}