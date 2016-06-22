using System;
using TechTalk.SpecFlow;

namespace E05.BDD.SpecFlow
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
        
        [Then(@"I am asked to pay (.*) PLN")]
        public void ThenIAmAskedToPayPLN(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am not asked for anything")]
        public void ThenIAmNotAskedForAnything()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am given (.*)% discount And I am asked to pay (.*) PLN")]
        public void ThenIAmGivenDiscountAndIAmAskedToPayPLN(Decimal p0, Decimal p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am offered (.*)% discount And I am asked to pay (.*) PLN")]
        public void ThenIAmOfferedDiscountAndIAmAskedToPayPLN(int p0, Decimal p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
