using System;

class Program
{
    static void Main(string[] args)
    {
        // Let's create some addresses!
        Address address1 = new Address("582 Hawthorne Heights", "Lawrenceburg", "IN", "USA");
        Address address2 = new Address("2691 E 3800 S", "St. George", "UT", "USA");

        // Let's makes some customers!
        Customer customer1 = new Customer("Fiona Barnett", address1);
        Customer customer2 = new Customer("Michael Scott", address2);

        // Let's create the first order!
        Order order1 = new Order(customer1);
        
        // Let's add products to order1!
        order1.AddProduct(new Product("Shampoo","SHAM%%6789",6.99,2));
        order1.AddProduct(new Product("Comb","COMB%%2312",4.50,1));
        order1.AddProduct(new Product("Toothpaste","TOOT%%9854",3.69,1));

        // Let's create the second order!
        Order order2 = new Order(customer2);

        // Let's add products to order2!
        order2.AddProduct(new Product("Screwdriver","SCRE%%1111",9.70,1));
        order2.AddProduct(new Product("Bucket","BUCK%%9056",10.07,1));
        order2.AddProduct(new Product("Twix","TWIX%%3568",1.99,5));

        // Let's create a list of orders!
        List<Order>orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);

        Console.Clear();
        Console.WriteLine("Here's the orders!");
        int index = 1;
        foreach (Order order in orders)
        {
            Console.WriteLine($"Order {index}");
            order.GetPackingLabel();
            order.GetShippingLabel();
            double total = order.CalculateTotalPrice();
            order.DisplayShippingCost();
            Console.WriteLine($"Total: ${total.ToString("0.00")}");
            index++;
            Console.WriteLine();

        }
    }
}