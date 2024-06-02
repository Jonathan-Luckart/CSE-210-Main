using System;

class Program
{
    static void Main(string[] args)
    {
        #region 
        List<Product> firstOrder = new List<Product>();
        List<Product> secondOrder = new List<Product>();
        List<Product> thirdOrder = new List<Product>();

        Product product1 = new Product("Banana Bunch", 101, 13, 4.98);
        Product product2 = new Product("Lego Set", 102, 8, 49.98);
        Product product3 = new Product("Sour Cream", 103, 16, 3.60);
        Product product4 = new Product("Dog Food", 104, 9, 19.98);
        Product product5 = new Product("Scooter", 105, 6, 99.98);
        Product product6 = new Product("TV Dinner", 106, 22, 3.98);
        Product product7 = new Product("Milk", 107, 14, 5.48);
        Product product8 = new Product("Card", 108, 65, 1.98);
        Product product9 = new Product("Steak", 109, 11, 14.98);
        Product product10 = new Product("Flatscreen TV", 110, 4, 499.98);

        firstOrder.Add(product2);
        firstOrder.Add(product5);
        firstOrder.Add(product10);
        secondOrder.Add(product1);
        secondOrder.Add(product4);
        secondOrder.Add(product8);
        thirdOrder.Add(product3);
        thirdOrder.Add(product6);
        thirdOrder.Add(product7);
        thirdOrder.Add(product9);

        Address address1 = new Address("5586 Zachary Prairie", "North Shardamouth", "Pennsylvania", "United States");
        Address address2 = new Address("Diehlstr. 9", "Tuttlingen", "Sachsen-Anhalt", "Germany");
        Address address3 = new Address("1039 Kristian Divide", "Danielburgh", "Washington", "United States");

        Customer customer1 = new Customer("Dave Micheals", address1);
        Customer customer2 = new Customer("Madds Gesunteit", address2);
        Customer customer3 = new Customer("Olivia Pierce", address3);

        Order order1 = new Order(firstOrder, customer1);
        Order order2 = new Order(secondOrder, customer2);
        Order order3 = new Order(thirdOrder, customer3);
        #endregion

        //output
        Console.WriteLine();
        Console.WriteLine("Order One:");
        Console.WriteLine($"Order Total: ${order1.TotalOrderCost()}");
        Console.WriteLine();
        Console.WriteLine($"Packing label: ");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Order Two:");
        Console.WriteLine($"Order Total: ${order2.TotalOrderCost()}");
        Console.WriteLine();
        Console.WriteLine($"Packing label: ");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Order Three:");
        Console.WriteLine($"Order Total: ${order3.TotalOrderCost()}");
        Console.WriteLine();
        Console.WriteLine($"Packing label: ");
        Console.WriteLine(order3.PackingLabel());
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order3.ShippingLabel());
        Console.WriteLine();
    }
}