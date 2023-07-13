


class Cycling : Activity
{
    public double _speed { get; set; }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Cycling ({LengthInMinutes} min) - Speed: {_speed:F1} mph, Pace: {GetPace():F1} min per mile";
    }
}