using System;
using E02.TDD.main;

namespace E02.TDD.test
{
    internal class ShoppingCartBuilder
    {
        private ShoppingCart cart;

        public ShoppingCartBuilder()
        {
            cart = new ShoppingCart();
        }

        internal ShoppingCart build()
        {
            return cart;
        }

        internal ShoppingCartBuilder withItems(ItemCollection items)
        {
            cart.Items = items;
            return this;
        }
    }
}