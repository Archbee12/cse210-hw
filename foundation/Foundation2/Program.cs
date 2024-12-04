using System;

class Program
{
    static void Main(string[] args)
    {
        Address _address = new Address("24 Badmus Str", "Anytown", "CA", "USA");
        Customer _customer = new Customer("John Doe", _address);
        Products _product = new Products("Phone Accessories", "PH23", 10.5, 3);
        Products _product2 = new Products("Laptop Bag", "LP34", 2.5, 4);

        _order.AddProducts(_product);
        _order.AddProducts(_product2);

        Console.WriteLine("Packing Label:");
        Console.WriteLine(_order.PackingLabel());
    }
}