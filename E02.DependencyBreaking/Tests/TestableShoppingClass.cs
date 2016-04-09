using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E03.DependencyBreaking.WebServiceContract;

namespace E03.DependencyBreaking.Tests
{
    class TestableShoppingClass : ShoppingCart
    {

        public override void SaveCart(ShoppingCart cart)
        {

        }
        public override PaymentRequest GiveDiscount(double total, bool isWholesale,IAppSettingsProvider provider)
        {
            provider = new FakeAppSettingsProvider();
            return base.GiveDiscount(total, isWholesale, provider);
        }
        public override void AddGifts(double total)
        {
            
        }
    }
}
