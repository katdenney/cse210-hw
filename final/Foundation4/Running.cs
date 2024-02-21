using System;
namespace ExerciseProj
{
    class Running : Exercise
    {
        private string _type = "Running";
        private float _distance;
        public Running(DateTime date, int minutes, float distance)
        :base(date,minutes)
        {
            _distance = distance;
        }
        public override string GetSummary()
        {
            return $"{_date.ToShortDateString()}{_type}({_minutes})-Distance {GetDistanceMiles()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
        }
        public override float GetDistanceMiles()
        {
            return _distance;
        }
        public override float GetSpeed()
        {
            return _distance /_minutes * 60;
        }
        public override float GetPace()
        {
            return 60/GetSpeed();
        } 
    }
}