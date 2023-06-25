using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Base class for goals
public abstract class Goal
{
    public string Name { get; set; }
    public bool IsCompleted { get; set; }

    public Goal(string name)
    {
        Name = name;
        IsCompleted = false;
    }

    public abstract int CalculatePoints();
    public abstract string GetStatus();
}

// Simple goal class
public class SimpleGoal : Goal
{
    private int points;

    public SimpleGoal(string name, int points) : base(name)
    {
        this.points = points;
    }

    public override int CalculatePoints()
    {
        if (IsCompleted)
            return points;
        else
            return 0;
    }

    public override string GetStatus()
    {
        if (IsCompleted)
            return "[X] " + Name;
        else
            return "[ ] " + Name;
    }
}

// Eternal goal class
public class EternalGoal : Goal
{
    private int points;

    public EternalGoal(string name, int points) : base(name)
    {
        this.points = points;
    }

    public override int CalculatePoints()
    {
        if (IsCompleted)
            return points;
        else
            return 0;
    }

    public override string GetStatus()
    {
        if (IsCompleted)
            return "[X] " + Name;
        else
            return "[ ] " + Name;
    }
}

// Checklist goal class
public class ChecklistGoal : Goal
{
    private int points;
    //private int targetCount;
    //private int currentCount;
    private int targetCount;
    private int currentCount;

    public int TargetCount => targetCount;
    public int CurrentCount => currentCount;

    public ChecklistGoal(string name, int points, int targetCount) : base(name)
    {
        this.points = points;
        this.targetCount = targetCount;
        currentCount = 0;
    }

    public override int CalculatePoints()
    {
        if (IsCompleted)
        {
            if (currentCount == targetCount)
                return points + 500; // Bonus points when goal is completed
            else
                return points;
        }
        else
        {
            return 0;
        }
    }

    public override string GetStatus()
    {
        if (IsCompleted)
            return "Completed " + currentCount + "/" + targetCount + " times - " + Name;
        else
            return "[ ] " + Name;
    }

    public void IncrementCount()
    {
        currentCount++;
        if (currentCount == targetCount)
            IsCompleted = true;
    }
}

// Main program
public class Program
{
    private static List<Goal> goals = new List<Goal>();

    public static void Main(string[] args)
    {
        LoadGoals();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. View Goals");
            Console.WriteLine("2. Add New Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewGoals();
                    break;
                case "2":
                    AddGoal();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    SaveGoals();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    private static void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                string goalType = parts[0];
                string name = parts[1];
                bool isCompleted = bool.Parse(parts[2]);

                Goal goal;
                if (goalType == "Simple")
                {
                    int points = int.Parse(parts[3]);
                    goal = new SimpleGoal(name, points);
                }
                else if (goalType == "Eternal")
                {
                    int points = int.Parse(parts[3]);
                    goal = new EternalGoal(name, points);
                }
                else if (goalType == "Checklist")
                {
                    int points = int.Parse(parts[3]);
                    int targetCount = int.Parse(parts[4]);
                    int currentCount = int.Parse(parts[5]);
                    goal = new ChecklistGoal(name, points, targetCount);
                    ((ChecklistGoal)goal).IsCompleted = isCompleted;
                    ((ChecklistGoal)goal).IncrementCount();
                }
                else
                {
                    Console.WriteLine("Unknown goal type: " + goalType);
                    continue;
                }

                goal.IsCompleted = isCompleted;
                goals.Add(goal);
            }
        }
    }

    private static void SaveGoals()
    {
        List<string> lines = new List<string>();
        foreach (Goal goal in goals)
        {
            string line = "";
            if (goal is SimpleGoal)
            {
                line += "Simple,";
                line += goal.Name + ",";
                line += goal.IsCompleted + ",";
                line += ((SimpleGoal)goal).CalculatePoints();
            }
            else if (goal is EternalGoal)
            {
                line += "Eternal,";
                line += goal.Name + ",";
                line += goal.IsCompleted + ",";
                line += ((EternalGoal)goal).CalculatePoints();
            }
            else if (goal is ChecklistGoal)
            {
                line += "Checklist,";
                line += goal.Name + ",";
                line += goal.IsCompleted + ",";
                //line += ((ChecklistGoal)goal).CalculatePoints() + ",";
                //line += ((ChecklistGoal)goal).targetCount + ",";
                //line += ((ChecklistGoal)goal).currentCount;

                line += ((ChecklistGoal)goal).CalculatePoints() + ",";
                line += ((ChecklistGoal)goal).TargetCount + ",";
                line += ((ChecklistGoal)goal).CurrentCount;

            }
            lines.Add(line);
        }
        File.WriteAllLines("goals.txt", lines);
    }

    private static void ViewGoals()
    {
        Console.Clear();
        Console.WriteLine("Goals:");
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.GetStatus());
        }
        Console.WriteLine();
        int totalPoints = goals.Sum(goal => goal.CalculatePoints());
        Console.WriteLine("Total Score: " + totalPoints);
    }

    private static void AddGoal()
    {
        Console.Clear();
        Console.WriteLine("Add New Goal");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter goal type: ");
        string goalType = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Goal goal;
        switch (goalType)
        {
            case "1":
                Console.Write("Enter points for completing the goal: ");
                int points = int.Parse(Console.ReadLine());
                goal = new SimpleGoal(name, points);
                goals.Add(goal);
                Console.WriteLine("Simple goal added successfully!");
                break;
            case "2":
                Console.Write("Enter points for each completion: ");
                int eternalPoints = int.Parse(Console.ReadLine());
                goal = new EternalGoal(name, eternalPoints);
                goals.Add(goal);
                Console.WriteLine("Eternal goal added successfully!");
                break;
            case "3":
                Console.Write("Enter points for each completion: ");
                int checklistPoints = int.Parse(Console.ReadLine());
                Console.Write("Enter target count for completion: ");
                int targetCount = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, checklistPoints, targetCount);
                goals.Add(goal);
                Console.WriteLine("Checklist goal added successfully!");
                break;
            default:
                Console.WriteLine("Invalid goal type. Please try again.");
                return;
        }
    }

    private static void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine("Record Event");
        Console.WriteLine("Enter the number corresponding to the goal you want to record an event for:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + goals[i].Name);
        }
        Console.Write("Enter your choice: ");
        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid choice. Please try again.");
            return;
        }

        if (choice >= 1 && choice <= goals.Count)
        {
            Goal selectedGoal = goals[choice - 1];
            selectedGoal.IsCompleted = true;
            if (selectedGoal is ChecklistGoal)
            {
                ((ChecklistGoal)selectedGoal).IncrementCount();
            }
            Console.WriteLine("Event recorded successfully!");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
}
