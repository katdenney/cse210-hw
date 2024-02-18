using System;
namespace ProductsProject
{
    class Customer
    {
        private string _name;
        private Address _address;
        public string Name   // property  Product p -> p.Name
        {
            get { return _name; }   // get method
            set { _name = value; }  // set method
        }
        public Address Address   // property  Product p -> p.Name
        {
            get { return _address; }   // get method
            set { _address = value; }  // set method
        }


        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }
        public Customer(string name)
        {
            _name = name;
        }
        public Customer(string name,string street,string city,string stateOrProvince,string country)
        {
            _name = name;
            _address = new Address(street, city, stateOrProvince, country);
        }
        public void SetNewAddress(string street,string city,string stateOrProvince,string country)
        {
            _address = new Address( street, city, stateOrProvince, country);
        }
        public bool GetIsUSA()
        {
            return _address.IsUSA();
        }
        public string GetShippingString()
        {
            return $"{_name} {_address}";
        }
    }
}