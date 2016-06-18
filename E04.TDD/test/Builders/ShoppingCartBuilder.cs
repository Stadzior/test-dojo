using System;
using E02.TDD.main;

namespace E02.TDD.test.Builders
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

        public ShoppingCart Build()
        {
            return cart;
        }

        internal ShoppingCartBuilder WithItems(ItemCollection items)
        {
            cart.Items = items;
            return this;
        }

        internal ShoppingCartBuilder WithPayment(Payment payment)
        {
            cart.Payment = payment;
            return this;
        }
    }
}