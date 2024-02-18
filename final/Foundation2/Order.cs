using System;
namespace ProductsProject
{
    class Order
    {
        private List <Product>_productList = new List<Product>();
        private Customer _customer;
        private string _orederNumber;

        public Order()
        {

        }
        public int GetTotalCost()
        {
            return 1;//just for now

        }
        public int GetShippingCost()
        {
            return 1;
        }
        public string GetPackingLabel()
        {
            return "string";
        }
        public string GetShippingLabel()
        {
            return "string";
        }
        public void DisplayPackingLabel()
        {

        }
        public void DisplayShippingLabel()
        {

        }
    }
}