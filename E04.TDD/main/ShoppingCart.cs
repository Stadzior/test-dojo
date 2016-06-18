using System;
using E02.TDD.test;

namespace E02.TDD.main
{
    internal class ShoppingCart
    {
        public ItemCollection Items { get; internal set; }
        public Payment Payment { get; set; }

        public ShoppingCart()
        {
            Payment = new Payment();
            Items = new ItemCollection();
        }

        internal void Checkout()
        {
        }
    }
}