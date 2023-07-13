

class Running : Activity
{
    public double _distance { get; set; }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / LengthInMinutes * 60;
    }

    public override double GetPace()
    {
        return LengthInMinutes / _distance;
    }

    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Running ({LengthInMinutes} min) - Distance: {_distance:F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}