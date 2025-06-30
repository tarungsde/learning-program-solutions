using System;
using System.Collections.Generic;

class SearchExample
{
    // Linear Search
    public static Product LinearSearch(Product[] products, int targetId)
    {
        foreach (var product in products)
        {
            if (product.ProductId == targetId)
                return product;
        }
        return null;
    }

    // Binary Search (Assumes sorted array by ProductId)
    public static Product BinarySearch(Product[] products, int targetId)
    {
        int left = 0, right = products.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (products[mid].ProductId == targetId)
                return products[mid];
            else if (products[mid].ProductId < targetId)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return null;
    }

    static void Main(string[] args)
    {
        Product[] products = {
            new Product(103, "Mouse", "Electronics"),
            new Product(101, "Laptop", "Electronics"),
            new Product(105, "Shoes", "Fashion"),
            new Product(102, "Keyboard", "Electronics"),
            new Product(104, "Shirt", "Fashion")
        };

        // Linear Search
        Console.WriteLine("Linear Search:");
        var linearResult = LinearSearch(products, 104);
        Console.WriteLine(linearResult != null
            ? $"Found: {linearResult.ProductName}"
            : "Product not found");

        // Binary Search (requires sorted array)
        Array.Sort(products, (a, b) => a.ProductId.CompareTo(b.ProductId));
        Console.WriteLine("\nBinary Search:");
        var binaryResult = BinarySearch(products, 104);
        Console.WriteLine(binaryResult != null
            ? $"Found: {binaryResult.ProductName}"
            : "Product not found");
    }
}
