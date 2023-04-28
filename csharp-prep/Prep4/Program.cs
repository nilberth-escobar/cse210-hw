using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("\nAddin numbers to a list and then sum, calculate average and max number");
        Console.WriteLine("\nEnter '0' when you want to stop ");

        string userNumber;
        int number = -1;

        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.WriteLine("\nEnter number: ");
            userNumber = Console.ReadLine();
            number = int.Parse(userNumber);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");
        
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

    }
}