using System;

public class Program
{
    static void Main(string[] args)
    {
        Address _address = new Address("24 Badmus Str", "Anytown", "CA", "USA");
        Customer _customer = new Customer("John Doe", _address);
        Order _order = new Order(_customer);

        Product _product1 = new Product("Phone Accessories", "PH23", 10.5, 3);
        Product _product2 = new Product("Laptop Bag", "LP34", 2.5, 4);

        _order.AddProduct( _product1);
        _order.AddProduct( _product2);

        Console.WriteLine("Packing Label:");
        Console.WriteLine(_order.PackingLabel());
        Console.WriteLine("\nShipping Label");
        Console.WriteLine(_order._shippingLabel());
        Console.WriteLine($"\nTotal Cost: ${_order.CalculateTotalCost():0.00}");
    }
}