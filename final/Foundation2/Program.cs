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
        Address lectureAddress = new Address("123 Main St", "Cityville", "State", "12345");
        Event lecture = new Lecture("Lecture Title", "Lecture Description", DateTime.Now, new TimeSpan(9, 0, 0), lectureAddress, "John Doe", 50);

        Address receptionAddress = new Address("456 Elm St", "Townsville", "State", "54321");
        Event reception = new Reception("Reception Title", "Reception Description", DateTime.Now, new TimeSpan(18, 0, 0), receptionAddress, "rsvp@example.com");

        Address outdoorGatheringAddress = new Address("789 Oak St", "Villagetown", "State", "98765");
        Event outdoorGathering = new OutdoorGathering("Outdoor Gathering Title", "Outdoor Gathering Description", DateTime.Now, new TimeSpan(15, 30, 0), outdoorGatheringAddress, "Sunny");

        // Generate and output marketing messages for each event
        Console.WriteLine("Lecture:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());

        Console.ReadLine();
    }
}
