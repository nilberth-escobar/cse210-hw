namespace GoalTracker
{
    // Eternal goal class
    public class EternalGoal : Goal
    {
        private int _points;

        public EternalGoal(string name, int points) : base(name)
        {
            this._points = points;
        }

        public override int CalculatePoints()
        {
            if (_isCompleted)
                return _points;
            else
                return 0;
        }

        public override string GetStatus()
        {
            if (_isCompleted)
                return "[X] " + _name;
            else
                return "[ ] " + _name;
        }
    }
}
