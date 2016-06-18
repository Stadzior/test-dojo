using System;

namespace E02.TDD.test.Builders
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

        internal ItemBuilder WithPrice(double price)
        {
            item.Price = price;
            return this;
        }

        internal ItemBuilder WithQuantity(double quantity)
        {
            item.Quantity = quantity;
            return this;
        }

        public Item Build()
        {
            return item;
        }

        internal ItemBuilder WithWholesale(int wholesale)
        {
            item.Wholesale = wholesale;
            return this;
        }
    }
}