using System;

namespace E02.TDD.test
{
    internal class ItemBuilder : IBuilder<Item>
    {
        private Item item;

        public ItemBuilder()
        {
            item = new Item();
        }

        public static ItemBuilder Item()
        {
            return new ItemBuilder();
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

        public Item build()
        {
            return item;
        }
    }
}