using Smart_Cart_Application;

namespace ShoppingCartApplicationTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddItem()
        {
            // Arrange
            var cart = new ShoppingCart();
            var product = new Product("TestProduct", 10.99m, ProductCategory.Food);

            // Act
            cart.AddItem(product);

            // Assert
            Assert.Single(cart.GetItems());
            Assert.Contains(product, cart.GetItems());
        }

        [Fact]
        public void TestRemoveItem()
        {
            // Arrange
            var cart = new ShoppingCart();
            var product = new Product("TestProduct", 10.99m, ProductCategory.Food);
            cart.AddItem(product);

            // Act
            cart.RemoveItem(product);

            // Assert
            Assert.Empty(cart.GetItems());
        }

        [Fact]
        public void TestCalculateTotal()
        {
            // Arrange
            var cart = new ShoppingCart();
            cart.AddItem(new Product("Product1", 10.00m, ProductCategory.Food));
            cart.AddItem(new Product("Product2", 20.00m, ProductCategory.Clothing));

            // Act
            var total = cart.CalculateTotal();

            // Assert
            Assert.Equal(30.00m, total);
        }
    }
}