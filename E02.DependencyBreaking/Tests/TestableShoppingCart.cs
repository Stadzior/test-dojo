using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E03.DependencyBreaking.WebServiceContract;

namespace E03.DependencyBreaking.Tests
{
    class TestableShoppingCart : ShoppingCart
    {
        private IAppSettingsProvider _provider;
        private IShopClient _client;

        public TestableShoppingCart(IAppSettingsProvider provider,IShopClient client) : base(provider,client)
        {
            _provider = provider;
            _client = client;
        } 

        public override void SaveCart(ShoppingCart cart)
        {
        }

        public override PaymentRequest GiveDiscount(double total, bool isWholesale)
        {
            return base.GiveDiscount(total, isWholesale);
        }

        public override void AddGifts(double total)
        {
            
        }
    }
}
