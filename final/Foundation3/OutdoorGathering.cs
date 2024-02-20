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
        
        public string GetStandardDetails()
        {
            return$"{base.Title},{base.Description}, {base.Date}, {base.Address}";

        }
        public override string GetFullDetails()
        {
            return $"{_kind} Event Full Details:\n*********\n Title:{base.Title}\nDescription:{base.Description}\nDate:{base.Date}\nAddress:{base.Address.GetAddress()}";
            //type of event, 
            //Lectures = speaker name, capacity 
            //Receptions = Emial RSVP confirmations
            //Outdoor gatherings = statment of weather
        }
        public override string GetShortDescription()
        {
            return $"The Type of event is {_kind}\nThe Title is: {base.Title}\nThe Date is: {base.Date}";

        }

    

    }
}