namespace Smart_Cart_Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            GroceryStore groceryStore = new GroceryStore();
            ClothingStore clothingStore = new ClothingStore();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Welcome to the Smart Shopping Cart Application!");
                Console.WriteLine("1. Shop at Grocery Store");
                Console.WriteLine("2. Shop at Clothing Store");
                Console.WriteLine("3. View Shopping Cart");
                Console.WriteLine("4. Calculate Total Cost");
                Console.WriteLine("5. Exit");
                Console.Write("Please select an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        ShopAtStore(groceryStore, cart);
                        break;
                    case "2":
                        ShopAtStore(clothingStore, cart);
                        break;
                    case "3":
                        ViewCart(cart);
                        break;
                    case "4":
                        Console.WriteLine($"Total Cost: ${cart.CalculateTotal():F2}");
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void ShopAtStore(dynamic store, ShoppingCart cart)
        {
            store.DisplayProducts();
            Console.Write("Enter the name of the product to add to cart: ");
            string productName = Console.ReadLine();
            Product product = store.GetProductByName(productName);

            if (product != null)
            {
                cart.AddItem(product);
                Console.WriteLine("Product added to cart.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        static void ViewCart(ShoppingCart cart)
        {
            Console.WriteLine("Shopping Cart Contents:");
            cart.ViewItems();
            Console.Write("Enter the name of the product to remove from cart (or press Enter to skip): ");
            string productName = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(productName))
            {
                Product productToRemove = cart.GetItems().Find(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));
                if (productToRemove != null)
                {
                    cart.RemoveItem(productToRemove);
                    Console.WriteLine("Product removed from cart.");
                }
                else
                {
                    Console.WriteLine("Product not found in cart.");
                }
            }
        }
    }
}