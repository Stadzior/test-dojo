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
        public ShoppingCart()
        {

        }

        public void Checkout()
        {
            var cart = this;
            double total = 0;
            bool isWholesale = true;

            if (Count == 0) return;

            using (var db = new ShopDbContext())
            {
                db.ShoppingCarts.Save(cart);
            }

            foreach (var product in cart)
            {
                isWholesale &= product.Quantity >= product.MinWholesaleQuantity;
                total += product.Price * product.Quantity;
            }

            using (var db = new ShopDbContext())
            {
                var gift = db.PromoGifts
                    .Where(g => total > g.MinOrderValue)
                    .OrderBy(g => g.MinOrderValue)
                    .FirstOrDefault();

                if (gift != null)
                {
                    this.Add(gift);
                }
            }

            IAppSettingsProvider provider = new AppSettingsProvider();
            var request = GiveDiscount(total, isWholesale, provider);

            var cli = new ShopWebClient();
            var response = cli.RequestPayment(request);

            if (response != null)
            {
                ExecutePayment(response);
            }
        }

        public PaymentRequest GiveDiscount(double total, bool isWholesale, IAppSettingsProvider provider)
        {

            PaymentRequest request = new PaymentRequest();
            if (total > (double) provider.GetAppSetting("DiscountTreshold"))
            {
                var discount = (double)provider.GetAppSetting("Discount");

                if (isWholesale) discount = discount * 2;

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

            throw new NotImplementedException();

            #endregion
        }
        
    }
}
