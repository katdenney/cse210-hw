using System;
using System.Net.NetworkInformation;
using System.Net.Sockets;
namespace EventsProject
{
    class Event
    {
        private string _title;
        private string _description;
        private string _date;
        private Address _address;

        public Event(string title, string description, string date, Address address)
        {
            _title = title;
            _description = description;
            _date = date;//do I want to use datetime
            _address = address;
        }
        public Event(string title, string description, string date)
        {
            _title = title;
            _description = description;
            _date = date;//do I want to use datetime
        }
        public Event(string title,string description, string date, string street,string city,string stateOrProvince,string country)
        {
            _title = title;
            _description = description;
            _date = date;
            _address = new Address(street, city, stateOrProvince, country);
        }
        public string Title   // property  Event e -> e.Event
        {
            get { return _title; }   // get method
            set { _title = value; }  // set method
        }
        public string Description   // property  Event e -> e.Event
        {
            get { return _description; }   // get method
            set { _description = value; }  // set method
        }
        public string Date   // property  Event e -> e.Event
        {
            get { return _date; }   // get method
            set { _date = value; }  // set method
        }
        public Address Address   // property  Event e -> e.Event
        {
            get { return _address; }   // get method
            set { _address = value; }  // set method
        }
        public void SetNewAddress(string street,string city,string stateOrProvince,string country)
        {
            _address = new Address( street, city, stateOrProvince, country);
        }

        public string GetStandardDetails()
        {
            Console.WriteLine("Standard Details:\n*********");
            return $"Event Title: {_title}\nDescription: {_description}\nDate: {_date}\nAddress:\n {Address.GetAddress()}";

        }
        public virtual string GetFullDetails()
        {
            return string.Empty;
            //type of event, 
            //Lectures = speaker name, capacity 
            //Receptions = Emial RSVP confirmations
            //Outdoor gatherings = statment of weather
        }
        public virtual string GetShortDescription()
        {
            return string.Empty;
            //this one shouldnt be used..
        }



    }
}