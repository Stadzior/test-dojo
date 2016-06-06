using E03.DependencyBreaking.WebServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03.DependencyBreaking
{
    public class ShoppingCart : List<Product>
    {
        private IAppSettingsProvider _provider;
        private IShopClient _client;
        

        public ShoppingCart(IAppSettingsProvider provider,IShopClient client)
        {
            _provider = provider;
            _client = client;
        }
        public void Checkout()
        {
            var cart = this;
            double total = 0;
            bool isWholesale = true;

            if (Count == 0) return;

            SaveCart(cart);

            foreach (var product in cart)
            {
                isWholesale &= product.Quantity >= product.MinWholesaleQuantity;
                total += product.Price * product.Quantity;
            }

            AddGifts(total);
            var request = GiveDiscount(total, isWholesale);

            var response = _client.RequestPayment(request);

            if (response != null)
            {
                ExecutePayment(response);
            }
        }

        public virtual void AddGifts(double total)
        {
            using (var db = new ShopDbContext())
            {
                var gift = db.PromoGifts
                    .Where(g => total > g.MinOrderValue)
                    .OrderBy(g => g.MinOrderValue)
                    .FirstOrDefault();

                if (gift != null)
                {
                   Add(gift);
                }
            }
        }

        public virtual void SaveCart(ShoppingCart cart)
        {
            using (var db = new ShopDbContext())
            {
                db.ShoppingCarts.Save(cart);
            }
        }

        public virtual PaymentRequest GiveDiscount(double total, bool isWholesale)
        {

            PaymentRequest request = new PaymentRequest();
            if (total > (double)_provider.GetAppSetting("DiscountTreshold"))
            {
                double discount = (double)_provider.GetAppSetting("Discount");
                if (isWholesale) discount *= 2;

                request.Total = total * (1 - discount);
                request.Discount = discount;
            }
            else
            {
                request.Total = total;
            }
            return request;
        }

        private void ExecutePayment(PaymentResponse response)
        {
            #region lots of code...

            

            #endregion
        }
        
    }
}
