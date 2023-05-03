using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2012;
        job1._endYear = 2018;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Senior Software Engineer";
        job2._company = "Twitter";
        job2._startYear = 2018;
        job2._endYear = 2022;
        job2.Display();


        Resume myResume = new Resume();
        myResume._name = "Nilberth Escobar";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}

public class Job
{
    //member variables
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    // the constructor of the class
    
    public Job()
    {
    }

    //displaying the information from the member variables
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

public class Resume
{
    // The C# convention is to start member variables with an underscore _
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    // the constructor of the class
    public Resume()
    {
    }

    // displaying the person's full name 
   
    public void Display()
    {
        Console.WriteLine($"\nName: {_name}");
        Console.WriteLine("Jobs:");

        foreach ( Job job in _jobs)
        {
            job.Display();
        }
    }

}