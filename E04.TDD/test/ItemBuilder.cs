using System;

namespace E02.TDD.test
{
    internal class ItemBuilder
    {
        private Item item;

        public ItemBuilder()
        {
            item = new Item();
        }

        internal ItemBuilder withPrice(double price)
        {
            item.Price = price;
            return this;
        }

        internal ItemBuilder withQuantity(double quantity)
        {
            item.Quantity = quantity;
            return this;
        }

        internal Item build()
        {
            return item;
        }
    }
}