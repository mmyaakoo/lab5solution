using System;
using System.Collections.Generic;
using System.Linq;



class Program
{
    static void Main()
    {
        Store onlineStore = new Store();

        // Adding users to the store
        User user1 = new User("JohnDoe", "password123");
        User user2 = new User("JaneSmith", "securePassword");
        onlineStore.AddUser(user1);
        onlineStore.AddUser(user2);

        // Adding products to the store
        Product product1 = new Product("Laptop", 1200.0, "High-performance laptop", "Electronics", 5);
        Product product2 = new Product("Smartphone", 800.0, "Latest smartphone model", "Electronics", 4);
        Product product3 = new Product("Book", 20.0, "Best-selling novel", "Books", 5);
        onlineStore.AddProduct(product1);
        onlineStore.AddProduct(product2);
        onlineStore.AddProduct(product3);

        // Displaying products in the store
        onlineStore.DisplayProducts();

        // Searching products by price
        List<Product> affordableProducts = onlineStore.SearchProducts(product1, 1000.0);
        Console.WriteLine("\nAffordable Products:");
        foreach (var product in affordableProducts)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Category: {product.Category}");
        }

        // Searching products by category
        List<Product> electronicsProducts = onlineStore.SearchProducts(product2, "Electronics");
        Console.WriteLine("\nElectronics Products:");
        foreach (var product in electronicsProducts)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Category: {product.Category}");
        }

        // Searching products by rating
        List<Product> highlyRatedProducts = onlineStore.SearchProducts(product3, 4);
        Console.WriteLine("\nHighly Rated Products:");
        foreach (var product in highlyRatedProducts)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Category: {product.Category}, Rating: {product.Rating}");
        }

        // Placing orders
        onlineStore.PlaceOrder(user1, new List<Product> { product1, product2 }, 2);
        onlineStore.PlaceOrder(user2, new List<Product> { product3 }, 3);

        // Displaying order history for users
        onlineStore.DisplayOrders(user1);
        onlineStore.DisplayOrders(user2);

        // Keep the console window open
        Console.ReadLine();
    }
}
