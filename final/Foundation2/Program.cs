using System;
namespace ProductsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Foundation2 World!");
            Address address1 = new Address("1265 Stanford Lane","Sandy","UT","USA");
            Customer customer1 = new Customer("Alice Johnson", address1);

            Customer customer2 = new Customer("Jack Reacher", "1 Pensylvania Ave","Langy","VA","USA");

            Customer customer3 = new Customer("Amy Hansen");
            customer3.SetNewAddress("1 Queensland Lane","London","EC83 0YS","UK");

            Product prod1 = new Product("lipstick", "abc456", 15.99F, 1);//*** learned I need an F for float and a D for double "literal double" or "literal float" //string name,string productID,int price,int qty
            Product prod2 = new Product("toaster","ABC123XYZ",129.99F, 2);
            Product prod3 = new Product("hoverboard","PQR456LMN",199.99F,3);
            Product prod4 = new Product("Lavender Shampoo","DEF789JKL",24.95F,2);
            Product prod5 = new Product("Tropical Breeze Deodorant","GHI234OPQ",10.32F,4);
            Product prod6 = new Product("Fruit Drink Pack","KYN2387PQ",19.52F,12);

            Order order1 = new Order(customer1, "N000011");
            Product[] prods = {prod1, prod2};
            order1.AddProducts(prods);
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            //Console.WriteLine($"Total Cost:{order1.GetTotalCost()}");
            order1.DisplayGetTotalCost();

            Order order2 = new Order(customer2,"N000012");
            Product[] prods2 = {prod3, prod4};
            order2.AddProducts(prods2);
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            //Console.WriteLine($"Total Cost:{order2.GetTotalCost()}");
            order2.DisplayGetTotalCost();

            Order order3 = new Order(customer3,"N000013");
            Product[] prods3 = {prod5,prod6};
            order3.AddProducts(prods3);
            Console.WriteLine(order3.GetPackingLabel());
            Console.WriteLine(order3.GetShippingLabel());
            //Console.WriteLine($"Total Cost:{order3.GetTotalCost()}");
            order3.DisplayGetTotalCost();


            

        }   
    }
}