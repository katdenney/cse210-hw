using System;
namespace EventsProject
{
    class Reception: Event
    { 
        private int _Rsvp;
        private string _kind = "Reception";

        public Reception (string title, string description, string date, Address address, int Rsvp)
        : base(title, description, date, address)
        {
            _Rsvp = Rsvp;
        }
        public Reception (string title, string description, string date, int Rsvp)
        : base(title, description, date)
        {
            _Rsvp = Rsvp;
        }
        public override string GetFullDetails()
        {
            return $"The Type of event is {_kind}.\n{base.GetStandardDetails()}\nRSVP Total: {_Rsvp}";
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