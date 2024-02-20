using System;
namespace EventsProject
{
    class OutdoorGathering : Event
    {
        
        private string _weather;
        private string _kind = "Outdoor Gathering";

        public OutdoorGathering (string title, string description, string date, Address address, string weather)
        : base(title, description, date, address)
        {
            _weather = weather;
        }
        public OutdoorGathering (string title, string description, string date, string weather)
        : base(title, description, date)
        {
            _weather = weather;
        }
        
        public override string GetFullDetails()
        {
            return $"The Type of event is {_kind}.\n{base.GetStandardDetails()}\nWeather: {_weather}";
            //type of event, 
            //Lectures = speaker name, capacity 
            //Receptions = Emial RSVP confirmations
            //Outdoor gatherings = statment of weather
        }
        public override string GetShortDescription()
        {
            return $"The Type of event is {_kind}.\nThe Title is: {base.Title}\nThe Date is: {base.Date}";

        }

    

    }
}