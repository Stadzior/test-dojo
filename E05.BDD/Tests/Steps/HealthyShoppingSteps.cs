using System;
using TechTalk.SpecFlow;
using E05.BDD.Core;
using E05.BDD.Core.Models;
using Shouldly;
using Moq;
namespace E05.BDD.SpecFlow.Tests.Steps
{
    [Binding]
    public class HealthyShoppingSteps
    {

        private ShoppingCart _cart;
        private PaymentRequest _request;

        [BeforeScenario]
        public void SetUp()
        {
            Mock<IShopRules> mockRules = new Mock<IShopRules>();
            Mock<IShopRepository> mockRepository = new Mock<IShopRepository>();
            mockRules.Setup(rule => rule.DiscountTreshold).Returns(249);
            mockRules.Setup(rule => rule.Discount).Returns(1.5);
            _cart = new ShoppingCart(mockRules.Object, mockRepository.Object);
        }

        [Given(@"I have (.*) kg of apples for (.*) PLN / kg in the cart")]
        public void GivenIHaveKgOfApplesForPLNKgInTheCart(int kiloCount, decimal amountPLN)
        {
            Product apples = new Product();
            apples.Quantity = kiloCount;
            apples.Price = (double)amountPLN;
            apples.Name = "apples";
            _cart.Add(apples);
          
        }
        
        [Given(@"I have (.*) loafs of bread for (.*) PLN / loaf in the cart")]
        public void GivenIHaveLoafsOfBreadForPLNLoafInTheCart(int loafCount, decimal amountPLN)
        {
            Product bread = new Product();
            bread.Quantity = loafCount;
            bread.Price = (double)amountPLN;
            bread.Name = "bread";
            _cart.Add(bread);
        }
        
        [Given(@"I have an empty cart")]
        public void GivenIHaveAnEmptyCart()
        {
            _cart.Clear();
        }
        
        [Given(@"I have (.*) TV Set for (.*) PLN in the cart")]
        public void GivenIHaveTVSetForPLNInTheCart(int tvCount, int amountPLN)
        {
            Product tv = new Product();
            tv.Quantity = tvCount;
            tv.Price = amountPLN;
            tv.Name = "tv";
            _cart.Add(tv);
        }
        
        [Given(@"I have (.*) kg of apples for (.*) PLN / kg \(with wholesale from (.*) kg\) in the cart")]
        public void GivenIHaveKgOfApplesForPLNKgWithWholesaleFromKgInTheCart(int kiloCount, decimal amountPLN, int kiloWholesaleCount)
        {
            Product apples = new Product();
            apples.Quantity = kiloCount;
            apples.Price = (double)amountPLN;
            apples.MinWholesaleQuantity = kiloWholesaleCount;
            apples.Name = "apples";
            _cart.Add(apples);
        }
        
        [When(@"I go to checkout")]
        public void WhenIGoToCheckout()
        {
            _request = _cart.Submit();
        }
        
        [Then(@"I am asked to pay (.*) PLN")]
        public void ThenIAmAskedToPayPLN(decimal amountPLN)
        {
            _request.Total.ShouldBe((double)amountPLN);
        }
        
        [Then(@"I am not asked for anything")]
        public void ThenIAmNotAskedForAnything()
        {
            _request.Total.ShouldBe(0);
        }
        
        [Then(@"I am given (.*)% discount And I am asked to pay (.*) PLN")]
        public void ThenIAmGivenDiscountAndIAmAskedToPayPLN(decimal percentDiscount, decimal amountPLN)
        {
            _request.Discount.ShouldBe((double)percentDiscount);
            _request.Total.ShouldBe((double)amountPLN);
        }
    }
}
