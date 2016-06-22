using System;
using TechTalk.SpecFlow;
using E05.BDD.Core;
namespace E05.BDD.SpecFlow.Tests.Steps
{
    [Binding]
    public class HealthyShoppingSteps
    {
        private ShoppingCart cart = new ShoppingCart(new Moq.Mock<IShopRules>().Object,new Moq.Mock<IShopRepository>().Object);

        [Given(@"I have (.*) kg of apples for (.*) PLN / kg in the cart")]
        public void GivenIHaveKgOfApplesForPLNKgInTheCart(int kiloCount, decimal amountPLN)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have (.*) loafs of bread for (.*) PLN / loaf in the cart")]
        public void GivenIHaveLoafsOfBreadForPLNLoafInTheCart(int loafCount, decimal amountPLN)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have an empty cart")]
        public void GivenIHaveAnEmptyCart()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have (.*) TV Set for (.*) PLN in the cart")]
        public void GivenIHaveTVSetForPLNInTheCart(int tvCount, int amountPLN)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have (.*) kg of apples for (.*) PLN / kg \(with wholesale from (.*) kg\) in the cart")]
        public void GivenIHaveKgOfApplesForPLNKgWithWholesaleFromKgInTheCart(int kiloCount, decimal amountPLN, int kiloWholesaleCount)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I go to checkout")]
        public void WhenIGoToCheckout()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am asked to pay (.*) PLN")]
        public void ThenIAmAskedToPayPLN(decimal amountPLN)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am not asked for anything")]
        public void ThenIAmNotAskedForAnything()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am given (.*)% discount And I am asked to pay (.*) PLN")]
        public void ThenIAmGivenDiscountAndIAmAskedToPayPLN(decimal percentDiscount, decimal amountPLN)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
