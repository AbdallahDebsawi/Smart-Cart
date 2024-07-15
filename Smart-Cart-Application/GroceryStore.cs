using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart_Application
{
    public class GroceryStore
    {
        private List<Product> products = new List<Product>();
        private ProductGenerator generator = new ProductGenerator();

        public GroceryStore()
        {
            // Generate some random products
            for (int i = 0; i < 5; i++)
            {
                products.Add(generator.GenerateProduct());
            }
        }

        public void DisplayProducts()
        {
            Console.WriteLine("Grocery Store Products:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

        public Product GetProductByName(string name)
        {
            return products.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}