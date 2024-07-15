using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart_Application
{
    public class ShoppingCart
    {
        private List<Product> items = new List<Product>();

        public void AddItem(Product product)
        {
            items.Add(product);
        }

        public void RemoveItem(Product product)
        {
            items.Remove(product);
        }

        public void ViewItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public List<Product> GetItems()
        {
            return items;
        }

        public decimal CalculateTotal()
        {
            return items.Sum(item => item.Price);
        }
    }
}