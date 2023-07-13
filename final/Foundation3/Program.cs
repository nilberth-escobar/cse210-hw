/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
    }
}*/

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create products
        Product product1 = new Product("Product 1", 1, 10.99, 2);
        Product product2 = new Product("Product 2", 2, 5.99, 3);

        // Create customer
        Address address = new Address("123 Street", "City", "State", "USA");
        Customer customer = new Customer("John Doe", address);

        // Create order and add products
        Order order1 = new Order(customer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Create another order
        Address address2 = new Address("456 Street", "City", "State", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(product1);

        // Display results
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.CalculateTotalPrice());

        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.CalculateTotalPrice());
    }
}
