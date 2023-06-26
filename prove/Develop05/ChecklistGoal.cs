namespace GoalTracker
{
    // Checklist goal class
    public class ChecklistGoal : Goal
    {
        private int _points;
        private int _targetCount;
        private int _currentCount;

        public int _TargetCount => _targetCount;
        public int _CurrentCount => _currentCount;

        public ChecklistGoal(string name, int points, int targetCount) : base(name)
        {
            this._points = points;
            this._targetCount = targetCount;
            _currentCount = 0;
        }

        public override int CalculatePoints()
        {
            if (_isCompleted)
            {
                if (_currentCount == _targetCount)
                    return _points + 500; // Bonus points when goal is completed
                else
                    return _points;
            }
            else
            {
                return 0;
            }
        }

        public override string GetStatus()
        {
            if (_isCompleted)
                return "Completed " + _currentCount + "/" + _targetCount + " times - " + _name;
            else
                return "[ ] " + _name;
        }

        public void IncrementCount()
        {
            _currentCount++;
            if (_currentCount == _targetCount)
                _isCompleted = true;
        }
    }
}
