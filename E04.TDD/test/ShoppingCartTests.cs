using System;
using E02.TDD.main;
using NUnit.Framework;
using Shouldly;

namespace E02.TDD.test
{
    class ShoppingCartTests
    {
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

