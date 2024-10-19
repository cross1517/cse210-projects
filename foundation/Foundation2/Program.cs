using System;

class Program
{
    static void Main(string[] args)
    {
        //Some nice products
        Product product1 = new Product("Laptop of Viewing", "G5512", 7999.99m, 1);
        Product product2 = new Product("Swiss Army Gremlin, Minion", "GREMLIN", 29.99m, 10);
        Product product3 = new Product("Apples", "APL", 0.99m, 12);
        Product product4 = new Product("Bananas", "BAN", 1.99m, 6);
        Product product5 = new Product("Oranges", "ORG", 2.99m, 3);
        Product product6 = new Product("Pineapples", "PNE", 3.99m, 2);
        Product product7 = new Product("Holy Hand Grenade", "HHG", 49.99m, 1);

        //Totally real addresses
        Address address1 = new Address("123 I Can Count", "Counting", "Count", "Countland");
        Address address2 = new Address("655 Totally Real Street", "Real Town", "51st State", "USA");

        //Totally real customers
        Customer customer1 = new Customer("Count Countula", address1);
        Customer customer2 = new Customer("Joe Schmoe", address2);

        //Totally real orders
        Order order1 = new Order(customer1, address1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product2);
        order1.AddProduct(product4);
        order1.AddProduct(product4);
        order1.AddProduct(product4);
        order1.AddProduct(product4);

        Order order2 = new Order(customer2, address2);
        order2.AddProduct(product3);
        order2.AddProduct(product5);
        order2.AddProduct(product6);
        order2.AddProduct(product7);

        //Totally real order summaries
        DisplayOrderInfo(order1);
        Console.WriteLine();
        DisplayOrderInfo(order2);
    }

    static void DisplayOrderInfo(Order order)
    {
        Console.WriteLine("Packing List:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order.GetTotalCost()}");
    }
}