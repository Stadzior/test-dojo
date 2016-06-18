﻿using System;
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
            foreach (var item in Items)
            {
                Payment.Value += item.Price * item.Quantity;
            }

            if (Payment.Value > 300)
            {
                Payment.PercentDiscount = 1.5;
            }
        }
    }
}