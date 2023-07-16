/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
    }
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of each event type
        Address lectureAddress = new Address("Main St", "San Sebastian", "Neuquen", "45");
        Event lecture = new Lecture("Introduction to AI", "Join us for an insightful lecture on the basics of Artificial Intelligence.", DateTime.Now, new TimeSpan(9, 0, 0), lectureAddress, "John Doe", 50);

        Address receptionAddress = new Address("456 Elm St", "Townsville", "State", "54321");
        Event reception = new Reception("Networking Reception", "Network with industry professionals and expand your connections at this exciting reception.", DateTime.Now, new TimeSpan(18, 0, 0), receptionAddress, "rsvp@example.com");

        Address outdoorGatheringAddress = new Address("789 Oak St", "Villagetown", "State", "98765");
        Event outdoorGathering = new OutdoorGathering("Summer Picnic", "Join us for a fun-filled outdoor picnic in the park. Bring your friends and family!", DateTime.Now, new TimeSpan(15, 30, 0), outdoorGatheringAddress, "Sunny");

        // Generate and output marketing messages for each event
        Console.WriteLine("Lecture:");
        Console.WriteLine();
        Console.WriteLine("STANDARD DESCRIPTION");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("FULL DETAILS");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("SHORT DESCRIPTION");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception:");
        Console.WriteLine();
        Console.WriteLine("STANDARD DESCRIPTION");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("FULL DETAILS");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("SHORT DESCRIPTION");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering:");
        Console.WriteLine();
        Console.WriteLine("STANDARD DESCRIPTION");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("FULL DETAILS");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("SHORT DESCRIPTION");
        Console.WriteLine(outdoorGathering.GetShortDescription());

        Console.ReadLine();
    }
}
