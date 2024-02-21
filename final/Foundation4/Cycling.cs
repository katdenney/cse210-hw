using System;
namespace ExerciseProj
{
    class Cycling : Exercise
    {
        private string _type = "Cycling";
        private float _speed;
        
        public Cycling(DateTime date, int minutes,float speed)
        :base(date,minutes)
        {
            _speed = speed;
        }
        public override string GetSummary()
        {
        return $"{_date}{_type}({_minutes})-Distance {GetDistanceMiles()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
        }
        public override float GetDistanceMiles()
        {//distance * _minutes/60 = _speed
            return GetPace() * _minutes;
        }

        public float GetSpeed()
        {
            return _speed;
        }
        public override float GetPace()
        {
            return 60/_speed;

        }
        
        
    }
}