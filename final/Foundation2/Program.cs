using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("5555 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Christian Gividen", address1);
        List<Product> productList1 = new List<Product>();
        {
            productList1.Add(new Product("Tablet", 1234321, 600, 2));
            productList1.Add(new Product("AMD 7900 GRE", 4444444, 550, 1));
            productList1.Add(new Product("Ryzen 5900x", 321213, 243.21, 1));
            productList1.Add(new Product("60 pc AirHead", 545667, 8.99, 4));
        }

        Product[] product1 = productList1.ToArray();
        Order order1 = new Order(customer1, product1);



        Address address2 = new Address("3434 Canadian Dr", "Alberta", "AL", "Canada");
        Customer customer2 = new Customer("Bob B.", address2);
        List<Product> productList2 = new List<Product>();
        {
            productList2.Add(new Product("8 Bit do Pro 2", 3323, 50.00, 2));
            productList2.Add(new Product("Samsung S21", 77989, 199.99, 1));
        }

        Product[] product2 = productList2.ToArray();
        Order order2 = new Order(customer2, product2);



        Address address3 = new Address("7678 Rosy St", "Provo", "UT", "USA");
        Customer customer3 = new Customer("Samantha Greenwood", address3);
        List<Product> productList3 = new List<Product>();
        {   productList3.Add(new Product("Watch", 22222, 35.00, 1));
            productList3.Add(new Product("5 pack shorts", 00008, 30, 1));
            productList3.Add(new Product("Monitor", 7777777, 365.99, 1));
            productList3.Add(new Product("6 pair pack Socks", 9988, 9.99, 3));
            productList3.Add(new Product("Popcorn", 00006, 15.00, 2));
            productList3.Add(new Product("Mouse", 0003322, 39.99, 1));
        }

        Product[] product3 = productList3.ToArray();
        Order order3 = new Order(customer3, product3);


        Console.WriteLine("-----------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalPrice()}");
        Console.WriteLine("-----------");
        Console.WriteLine();

        Console.WriteLine("-----------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalPrice()}");
        Console.WriteLine("-----------");
        Console.WriteLine();

        Console.WriteLine("-----------");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order3.GetTotalPrice()}");
        Console.WriteLine("-----------");
        Console.WriteLine();
    }
}