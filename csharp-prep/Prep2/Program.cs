using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("\n-------------------");
        Console.WriteLine("\n--Grade Calculator--");
        Console.WriteLine("\n-------------------");

        //int grade;

        string gradeLetter = "";

        Console.WriteLine("Please enter your grade as an integer numbers: ");
        string grade = Console.ReadLine();

        int finalGrade = int.Parse(grade);

        if (finalGrade >= 90)
        {
            //Console.WriteLine($"Your final grade is: A");
            gradeLetter = "A";
        }

        else if (finalGrade >= 80)
        {
            //Console.WriteLine($"Your final grade is: B");
            gradeLetter = "B";
        }

        else if (finalGrade >= 70)
        {
            //Console.WriteLine($"Your final grade is: C");
            gradeLetter = "C";
        }

        else if (finalGrade >= 60)
        {
            //Console.WriteLine($"Your final grade is: D");
            gradeLetter = "D";
        }

        else
        {
            //Console.WriteLine($"Your final grade is: F");
            gradeLetter = "F";
        }


        if (finalGrade >= 70)
        {
            Console.WriteLine("\nCongrats! You passed the class");
            Console.WriteLine($"\nYour grade is: {finalGrade}, You got {gradeLetter}.");
        }

        else
        {
            Console.WriteLine("You did not pass the class \nYou need to do some improvements");
        }

    }

}
