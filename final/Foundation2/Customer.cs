using System;
namespace ProductsProject
{
    class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name,Address address)
        {
            _name = name;
            _address = address;
        }
        public bool GetIsUSA()
        {
            return true;//just for now
        }
        
    }
}