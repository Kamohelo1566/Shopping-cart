using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Product p1 = new Product("Nike", 125.14, "Shoes");      //add your products here
        Product p2 = new Product("Samsung", 35.24, "SmartPhone");
        Product p3 = new Product("Apple", 1.24, "Food");

        ShoppingCart s1 = new ShoppingCart();

        s1.AddProduct(p1);
        s1.AddProduct(p2);
        s1.AddProduct(p3);

        s1.CalculateTotal(); // Call to calculate total
        s1.CountItems(); // Call to count items
    }
}

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string CategoryProperties { get; set; }

    public Product(string name, double price, string categoryProperties)
    {
        Name = name;
        Price = price;
        CategoryProperties = categoryProperties;
    }
}

public class ShoppingCart
{
    List<Product> ProductList;

    public ShoppingCart()
    {
        ProductList = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        ProductList.Add(product);
    }

    public void RemoveProduct(Product product)
    {
        ProductList.Remove(product);
    }

    public void CountItems()
    {
        int count = ProductList.Count;
        Console.WriteLine($"The number of products: {count}");
    }

    public void CalculateTotal()
    {
        double total = 0;

        foreach (var product in ProductList)
        {
            total += product.Price; // Sum up the prices of all products
        }

        if (total > 0)
        {
            Console.WriteLine($"The total cost of all your items is {total}"); // Print total in currency format
        }
        else
        {
            Console.WriteLine("Error: No products added");
        }
    }
}

