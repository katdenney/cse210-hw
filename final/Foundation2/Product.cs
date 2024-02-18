using System;
using System.Dynamic;
namespace ProductsProject
{
    class Product
    {
        private string _name;
        private string _productID;
        private float _price;
        private int _qty;

        public string Name   // property  Product p -> p.Name
        {
            get { return _name; }   // get method
            set { _name = value; }  // set method
        }
        public Product(string name,string productID,float price,int qty)
        {
            _name = name;
            _productID = productID;
            _price = price;
            _qty = qty;
        }
        public float TotalCost()
        {
            return _price * _qty;
        }

        public string GetPackingString()
        {
            return $"{_name} {_productID}";
        }
    }
}