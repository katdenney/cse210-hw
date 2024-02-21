using System;
namespace Exercise
{
    class Activity
    {
        protected DateTime _date;
        protected int _minutes;

        public Activity(DateTime date, int minutes)
        {
            _date = date;
            _minutes = minutes;

        }
        public virtual string GetSummary()
        {//output Date: Activity(Minutes)-Distance float miles,Speed float mph,Pace: float min per
        return string.Empty;

        }
        public virtual void DisplaySummary()
        {

        }
        public virtual float GetDistanceMiles()
        {
            return 0;
            
        }
        public virtual float GetSpeed()
        {
            return 0;
            

        }
        public virtual float GetPace()
        {
            return 0;

        }

        
    }
}