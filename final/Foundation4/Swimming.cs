using System;
namespace Exercise
{
    class Swimming : Activity
    {
        private string _type = "Swimming";
        private int _laps;
        public int GetLaps()
        {
            return _laps;
        }

        public Swimming(DateTime date,int minutes,int laps)
        :base(date,minutes)
        {
            _laps = laps;
        }
        public override string GetSummary()
        {
        return $"{_date}{_type}({_minutes})-Distance {GetDistanceMiles()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
        }
        public override float GetDistanceMiles()
        {//Distance (miles) = swimming laps * 50 / 1000 * 0.62
            
            return _laps * .05F *.62F;//F for float!!!
            

        }
        public override float GetSpeed()
        {//Speed (mph or kph) = (distance / minutes) * 60
            return (GetDistanceMiles() / _minutes) * 60;

        }
        public override float GetPace()
        {//pace = minutes / distance
            return _minutes / GetDistanceMiles();


        }
        

        
    }
}