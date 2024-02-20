using System;
namespace EventsProject
{
    class Reception: Event
    { 
        private int _RSVP;
        private string _kind = "Reception";

        public Reception (string title, string description, string date, Address address, int RSVP)
        : base(title, description, date, address)
        {
            _RSVP = RSVP;
        }
        public Reception (string title, string description, string date, int RSVP)
        : base(title, description, date)
        {
            _RSVP = RSVP;
        }
        public string GetStandardDetails()
        {
            return $"{base.Title},{base.Description}, {base.Date}, {base.Address}";

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
            return $"The Type of event is: {_kind}\nThe Title is: {base.Title}\nThe Date is: {base.Date}";

        }
    }
}