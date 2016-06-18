using System;
using E02.TDD.main;

namespace E02.TDD.test
{
    internal class ShoppingCartBuilder : IBuilder<ShoppingCart>
    {
        private ShoppingCart cart;

        public static ShoppingCartBuilder Cart()
        {
            return new ShoppingCartBuilder();
        }

        public ShoppingCartBuilder()
        {
            cart = new ShoppingCart();
        }

        public ShoppingCart build()
        {
            return cart;
        }

        internal ShoppingCartBuilder withItems(ItemCollection items)
        {
            cart.Items = items;
            return this;
        }

        internal ShoppingCartBuilder withPaymentDate(DateTime paymentDate)
        {
            cart.Payment.Date = paymentDate;
            return this;
        }

    }
}