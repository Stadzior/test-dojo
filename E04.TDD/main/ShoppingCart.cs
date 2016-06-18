using System;
using E02.TDD.test;

namespace E02.TDD.main
{
    internal class ShoppingCart
    {

        private const double REGULAR_DISCOUNT_LEVEL = 300;
        private const double XMAS_DISCOUNT_LEVEL = 400;
        private const double REGULAR_DISCOUNT_PERCENT = 1.5;
        private const double XMAS_DISCOUNT_PERCENT = 0.75;
        private const double NO_DISCOUNT = 0.0;

        public ItemCollection Items { get; internal set; }
        public Payment Payment { get; set; }

        public ShoppingCart()
        {
            Payment = new Payment();
            Items = new ItemCollection();
        }

        internal void Checkout()
        {
            foreach (var item in Items)
            {
                Payment.Value += item.Price * item.Quantity;
            }

            double discountLevel = Payment.Date.Equals(SpecialDateTime.Xmas()) ? XMAS_DISCOUNT_LEVEL : REGULAR_DISCOUNT_LEVEL;
            double discountPercent = Payment.Date.Equals(SpecialDateTime.Xmas()) ? XMAS_DISCOUNT_PERCENT : REGULAR_DISCOUNT_PERCENT;

            if (Payment.Value > discountLevel)
            {
                Payment.PercentDiscount = Payment.Value > discountLevel ? discountPercent : NO_DISCOUNT;
            }           
        }
    }
}