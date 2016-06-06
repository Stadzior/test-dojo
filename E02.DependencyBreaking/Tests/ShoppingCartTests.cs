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
            FakeAppSettingsProvider fakeProvider = new FakeAppSettingsProvider(0.01, 1000);
            FakeShopWebClient fakeClient = new FakeShopWebClient();
            TestableShoppingCart cart = new TestableShoppingCart(fakeProvider,fakeClient);

            // Act
            var request = cart.GiveDiscount(total, isWholesale);

            // Assert

            request.Discount.ShouldBe(0.02);
        }

        [Test]
        public void DrinkingBeer_ShouldBeAllowed_WhenThatTestsPass()
        {
            // Arrange
            FakeAppSettingsProvider fakeProvider = new FakeAppSettingsProvider();
            FakeShopWebClient fakeClient = new FakeShopWebClient();
            TestableShoppingCart cart = new TestableShoppingCart(fakeProvider, fakeClient);
            Product item = new Product(1,1,1);
            cart.Add(item);

            // Act
            cart.Checkout();

            // Assert
            true.ShouldBeTrue();
        }
    }
}
