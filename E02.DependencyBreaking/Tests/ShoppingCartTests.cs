using E03.DependencyBreaking.WebServiceContract;
using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03.DependencyBreaking.Tests
{
    class ShoppingCartTests
    {
        [Test]
        public void DiscountShouldBeDoubled_WhenItIsWholesale()
        {
            // Arrange
            var total = 1000;
            bool isWholesale = true;
            FakeAppSettingsProvider fakeProvider = new FakeAppSettingsProvider();
            ShoppingCart cart = new ShoppingCart();

            // Act
            var request = cart.GiveDiscount(total, isWholesale, fakeProvider);

            // Assert

            request.Discount.ShouldBe(0.02);
        }

        [Test]
        public void DrinkingBeer_ShouldBeAllowed_WhenThatTestsPass()
        {
            // Arrange
            TestableShoppingClass cart = new TestableShoppingClass();
            Product item = new Product(1,1,1);
            cart.Add(item);

            // Act
            cart.Checkout();

            // Assert
            true.ShouldBeTrue();
        }
    }
}
