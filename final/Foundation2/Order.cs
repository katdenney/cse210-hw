using System;
namespace ProductsProject
{
    class Order
    {
        private List <Product>_productList = new List<Product>();
        private Customer _customer;
        private string _orderNumber;

        public Order(Customer customer, string orderNumber)
        {
            _customer = customer;
            _orderNumber = orderNumber;
        }
        public double GetTotalCost()
        {
            double totalCost = 0;
            foreach (Product p in _productList)
            {
                totalCost += p.TotalCost();
            }
            totalCost += GetShippingCost();
            double rounded = Math.Round(totalCost,2);
            return rounded;
            //The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost
        }
        public void DisplayGetTotalCost()
        {
            Console.WriteLine($"Order Number: ${_orderNumber}");
            Console.WriteLine($"Total Cost: ${GetTotalCost()}");

        }
        public int GetShippingCost()
        {
            if (_customer.GetIsUSA())
            {
                return 5;
            }
            else return 35;
            //USA, then the shipping cost is $5
            //not in the USA, then the shipping cost is $35
        }
        public string GetPackingLabel()
        {
            Console.WriteLine("Packing Label:");
            string label = "";
            foreach(Product p in _productList){
                label += p.GetPackingString() + "\n";
            }
            return label;
        }
        public string GetShippingLabel()
        {
            Console.WriteLine("Shipping Label:");
            return $"{_customer.Name},{_customer.Address.GetAddress()}";
        }
        
        public void AddProduct(string name,string productID,float price,int qty)
        {
            Product newProduct = new Product(name, productID, price,qty);
            _productList.Add(newProduct);
        }

        public void AddProduct(Product newProduct)
        {
            _productList.Add(newProduct);
        }

        public void AddProducts(Product[] newProducts)
        {
            foreach(Product p in newProducts)
            {
                 _productList.Add(p);
            }
        }
    }
}