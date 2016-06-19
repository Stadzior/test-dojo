﻿using System;
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
            Payment.Value = CalculateValue();
            Payment.PercentDiscount = CalculatePercentDiscount();
            Payment.Total = Payment.Value - (Payment.Value * Payment.PercentDiscount) / 100;
        }

        private double CalculateValue()
        {
            double value = 0.0;
            foreach (var item in Items)
            {
                value += item.Price * item.Quantity;
            }
            return value;
        }

        private double CalculatePercentDiscount()
        {
            double percentDiscount = 0.0;
            foreach (var item in Items)
            {
                item.PercentDiscount = item.PercentDiscount == 0 ? CalculateItemPercentDiscount(item) : item.PercentDiscount;
                percentDiscount += item.PercentDiscount;
            }
            percentDiscount /= Items.Count;

            return percentDiscount;
        }

        private double CalculateItemPercentDiscount(Item item)
        {
            double discountLevel = Payment.Date.Equals(SpecialDateTime.Xmas()) ? XMAS_DISCOUNT_LEVEL : REGULAR_DISCOUNT_LEVEL;
            double discountPercent = Payment.Date.Equals(SpecialDateTime.Xmas()) ? XMAS_DISCOUNT_PERCENT : REGULAR_DISCOUNT_PERCENT;

            discountPercent = Payment.Value > discountLevel ? discountPercent : NO_DISCOUNT;
            discountPercent = item.Wholesale > 0 && item.Quantity > item.Wholesale ? discountPercent*2 : discountPercent;
            
            return discountPercent;
        }
    }
}