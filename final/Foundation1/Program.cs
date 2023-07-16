/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
    }
}*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create videos. Title, Author and length
        Video video1 = new Video("Flutter from scratch", "FreeCodeCamp.org", 5);
        video1.AddComment("John", "Great video!");
        video1.AddComment("Amy", "I learned a lot from this.");

        Video video2 = new Video("JavaScript for beginners", "Fernando Solano", 8);
        video2.AddComment("Mike", "Nice explanation!");
        video2.AddComment("Sarah", "This video helped me understand the topic better.");

        Video video3 = new Video("People are Awesome vs fail", "People are Awesome", 1);
        video3.AddComment("David", "Very informative.");
        video3.AddComment("Lisa", "I enjoyed watching this.");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display video information
        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length: " + video._length + " hours");
            Console.WriteLine("Number of comments: " + video.GetNumberOfComments());

            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine("  Comment by " + comment._name + ": " + comment._text);
            }

            Console.WriteLine();
        }
    }
}




