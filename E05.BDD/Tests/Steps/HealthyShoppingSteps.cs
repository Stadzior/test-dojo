using System;
using TechTalk.SpecFlow;

namespace E05.BDD.SpecFlow.Tests.Steps
{
    [Binding]
    public class HealthyShoppingSteps
    {
        [Given(@"I have (.*) kg of apples for (.*) PLN / kg in the cart")]
        public void GivenIHaveKgOfApplesForPLNKgInTheCart(int p0, Decimal p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have (.*) loafs of bread for (.*) PLN / loaf in the cart")]
        public void GivenIHaveLoafsOfBreadForPLNLoafInTheCart(int p0, Decimal p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have an empty cart")]
        public void GivenIHaveAnEmptyCart()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have (.*) TV Set for (.*) PLN in the cart")]
        public void GivenIHaveTVSetForPLNInTheCart(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have (.*) kg of apples for (.*) PLN / kg \(with wholesale from (.*) kg\) in the cart")]
        public void GivenIHaveKgOfApplesForPLNKgWithWholesaleFromKgInTheCart(int p0, Decimal p1, int p2)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I go to checkout")]
        public void WhenIGoToCheckout()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I'm asked to pay (.*) PLN")]
        public void ThenIMAskedToPayPLN(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I'm not asked for anything")]
        public void ThenIMNotAskedForAnything()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I'(.*)'m asked to pay (.*) PLN")]
        public void ThenIMAskedToPayPLN(string p0, Decimal p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
