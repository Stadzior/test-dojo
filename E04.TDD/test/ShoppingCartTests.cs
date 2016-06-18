using System;
using E02.TDD.main;
using NUnit.Framework;
using Shouldly;
using Moq;

namespace E02.TDD.test
{
    [TestFixture]
    class ShoppingCartTests
    {

        [OneTimeSetUp]
        public void SetUp()
        {
        }

    [Test]
        public void Charge_ShouldBeZero_WhenCartIsEmpty()
        {
            // Arrange
            ShoppingCart cart = a(Cart().withItems(ItemCollection.Empty()));
            
            // Act
            cart.Checkout();

            // Assert
            cart.Payment.Value.ShouldBe(0.0);
        }

        [Test]
        public void Charge_ShouldBeOneHundred_WhenCartContainsTwoProducts_WhichCostsFifty()
        {
            // Arrange
            Item item = a(Item().withPrice(50.0).withQuantity(2));
            ItemCollection items = a(Items().withItem(item));
            ShoppingCart cart = a(Cart().withItems(items));

            // Act
            cart.Checkout();

            // Assert
            cart.Payment.Value.ShouldBe(100.0);
        }

        private ShoppingCartBuilder Cart()
        {
            return new ShoppingCartBuilder();
        }

        private ShoppingCart a(ShoppingCartBuilder builder)
        {
            return builder.build();
        }
    }
}

