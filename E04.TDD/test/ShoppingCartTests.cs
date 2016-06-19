using System;
using E02.TDD.main;
using NUnit.Framework;
using Shouldly;
using Moq;
using E02.TDD.test;
using static E02.TDD.test.Builders.ItemBuilder;
using static E02.TDD.test.Builders.ItemCollectionBuilder;
using static E02.TDD.test.Builders.ShoppingCartBuilder;
using static E02.TDD.test.Builders.PaymentBuilder;
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
            ShoppingCart cart = a(Cart().WithItems(ItemCollection.Empty()));
            
            // Act
            cart.Checkout();

            // Assert
            cart.Payment.Value.ShouldBe(0.0);
        }

        [Test]
        public void Charge_ShouldBeOneHundred_WhenCartContainsTwoProducts_WhichCostsFifty()
        {
            // Arrange
            Item item = a(Item().WithPrice(50.0).WithQuantity(2));
            ItemCollection items = a(Items().WithItem(item));
            ShoppingCart cart = a(Cart().WithItems(items));

            // Act
            cart.Checkout();

            // Assert

            cart.Payment.Value.ShouldBe(100.0);
        }

        [Test]
        public void Discount_ShouldBeOnePointFive_WhenPaymentValue_ExceedsThreeHundred()
        {
            // Arrange
            Item item = a(Item().WithPrice(1000.0).WithQuantity(1));
            ItemCollection items = a(Items().WithItem(item));
            ShoppingCart cart = a(Cart().WithItems(items));

            // Act
            cart.Checkout();

            // Assert
            cart.Payment.PercentDiscount.ShouldBe(1.5);
        }

        [Test]
        public void Discount_ShouldBeNoughtPointSeventyFive_WhenThereIsXmas()
        {
            // Arrange
            Item item = a(Item().WithPrice(100.0).WithQuantity(1));
            ItemCollection items = a(Items().WithItem(item));
            Payment payment = a(Payment().WithDate(SpecialDateTime.Xmas()));
            ShoppingCart cart = a(Cart().WithItems(items).WithPayment(payment));

            // Act
            cart.Checkout();

            // Assert
            cart.Payment.PercentDiscount.ShouldBe(0.75);
        }

        [Test]
        public void Total_ShouldBeNineEightFive_WhenPaymentValueIsOneThousand()
        {
            // Arrange
            Item item = a(Item().WithPrice(1000.0).WithQuantity(1));
            ItemCollection items = a(Items().WithItem(item));
            ShoppingCart cart = a(Cart().WithItems(items));

            // Act
            cart.Checkout();

            // Assert
            cart.Payment.Total.ShouldBe(985);
        }

        [Test]
        public void Discount_ShouldBeDoubledToThreePercent_WhenWholesaleAmountIsReached()
        {
            // Arrange
            Item item = a(Item().WithPrice(1000.0).WithQuantity(100).WithWholesale(99));
            ItemCollection items = a(Items().WithItem(item));
            ShoppingCart cart = a(Cart().WithItems(items));

            // Act
            cart.Checkout();

            // Assert
            cart.Payment.PercentDiscount.ShouldBe(3);
        }

        private T a<T> (IBuilder<T> builder)
        {
            return builder.Build();
        }
    }
}

