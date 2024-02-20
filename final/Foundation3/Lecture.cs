using System;
namespace EventsProject
{
    class Lecture : Event
    { 
        private string _speaker;
        private int _maxQty;
        private string _kind = "Lecture";

        public Lecture (string title, string description, string date, Address address, string speaker,int maxQty)
        : base(title, description, date, address)
        {
            _speaker = speaker;
            _maxQty = maxQty;

        }
        public Lecture (string title, string description, string date, string street,string city,string stateOrProvince,string country, string speaker,int maxQty)
        : base(title, description, date, street, city, stateOrProvince, country )
        {
            _speaker = speaker;
            _maxQty = maxQty;
        }
        public override string GetFullDetails()
        {
            return $"{base.GetStandardDetails()}Address:{base.Address.GetAddress()} Speaker:{_speaker} Capacity:{_maxQty}";
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