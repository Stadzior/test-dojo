using System;
using E02.TDD.test;

namespace E02.TDD.main
{
    internal class ShoppingCart
    {
        private const double DISCOUNT_LEVEL = 300;
        private const double REGULAR_DISCOUNT_PERCENT = 1.5;
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

            Payment.PercentDiscount = Payment.Value > DISCOUNT_LEVEL ? REGULAR_DISCOUNT_PERCENT : NO_DISCOUNT;
        }
    }
}