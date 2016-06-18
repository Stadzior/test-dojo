using System;

namespace E02.TDD.test
{
    internal class ItemCollectionBuilder : IBuilder<ItemCollection>
    {
        private ItemCollection items;

        public ItemCollectionBuilder()
        {
            items = new ItemCollection();
        }

        public static ItemCollectionBuilder Items()
        {
            return new ItemCollectionBuilder();
        }

        internal ItemCollectionBuilder withItem(Item item)
        {
            items.Add(item);
            return this;
        }

        public ItemCollection build()
        {
            return items;
        }
    }
}