class Swimming : Activity
{
    public int _laps { get; set; } // Number of laps swum during the activity

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
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
        return $"{Date.ToString("dd MMM yyyy")} Swimming ({LengthInMinutes} min) - Laps: {_laps}, Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}