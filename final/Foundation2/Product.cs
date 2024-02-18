using System;
namespace ProductsProject
{
    class Product
    {
        private string _name;
        private string _productID;
        private int _price;
        private int _qty;

        public Product(string name,string productID,int price,int qty)
        {
            _name = name;
            _productID = productID;
            _price = price;
            _qty = qty;
        }
        public int TotalCost()
        {
            return 1;
        }
    }
}