using System;

namespace GoalTracker
{
    // Base class for goals
    public abstract class Goal
    {
        public string _name { get; set; }
        public bool _isCompleted { get; set; }

        public Goal(string name)
        {
            _name = name;
            _isCompleted = false;
        }

        public abstract int CalculatePoints();
        public abstract string GetStatus();
    }
}
