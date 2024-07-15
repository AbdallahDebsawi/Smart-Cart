using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart_Application
{
    public class ProductGenerator
    {
        private static Random random = new Random();
        private static string[] productNames = { "Apple", "Jeans", "Laptop", "Banana", "T-Shirt", "Smartphone" };

        public Product GenerateProduct()
        {
            string name = productNames[random.Next(productNames.Length)];
            decimal price = (decimal)(random.NextDouble() * 100);
            ProductCategory category = (ProductCategory)random.Next(Enum.GetNames(typeof(ProductCategory)).Length);
            return new Product(name, price, category);
        }
    }
}