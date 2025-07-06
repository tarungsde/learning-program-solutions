using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RetailInventory
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new AppDbContext();

            // ✅ Step 1: Retrieve all products
            var products = await context.Products.Include(p => p.Category).ToListAsync();
            Console.WriteLine("📦 All Products:");
            foreach (var p in products)
                Console.WriteLine($"{p.Name} - ₹{p.Price} - Category: {p.Category?.Name}");

            // 🔍 Step 2: Find by ID (ID = 1)
            var product = await context.Products.FindAsync(1);
            Console.WriteLine($"\n🔍 Found by ID: {product?.Name} - ₹{product?.Price}");

            // 💰 Step 3: FirstOrDefault with condition (Price > 50000)
            var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
            Console.WriteLine($"\n💰 Expensive Product: {expensive?.Name} - ₹{expensive?.Price}");
        }
    }
}
