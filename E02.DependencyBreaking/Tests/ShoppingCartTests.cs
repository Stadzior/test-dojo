using E03.DependencyBreaking.WebServiceContract;
using Moq;
using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03.DependencyBreaking.Tests
{
    [TestFixture]
    class ShoppingCartTests
    {
        private Mock<IAppSettingsProvider> providerMock;
        private Mock<IShopClient> clientMock;
        private TestableShoppingCart cart;

        [OneTimeSetUp]
        public void SetUp()
        {
            providerMock = new Mock<IAppSettingsProvider>();
            providerMock.Setup(provider => provider.GetAppSetting("Discount")).Returns(0.01);
            providerMock.Setup(provider => provider.GetAppSetting("DiscountTreshold")).Returns(999);

            clientMock = new Mock<IShopClient>();
            clientMock.Setup(client => client.RequestPayment(It.IsAny<PaymentRequest>())).Returns(new PaymentResponse());

            cart = new TestableShoppingCart(providerMock.Object, clientMock.Object);
        }

        [Test]
        public void DiscountShouldBeDoubled_WhenItIsWholesale()
        {
            // Arrange
            var total = 1000;
            bool isWholesale = true;

            // Act
            var request = cart.GiveDiscount(total, isWholesale);

            // Assert

            request.Discount.ShouldBe(0.02);
        }

        [Test]
        public void DrinkingBeer_ShouldBeAllowed_WhenThatTestsPass()
        {
            // Arrange

            Product item = new Product(1,1,1);
            cart.Add(item);

            // Act
            cart.Checkout();

            // Assert
            true.ShouldBeTrue();
        }

        [OneTimeTearDown]
        public void TearDown()
        {

        }
    }
}
