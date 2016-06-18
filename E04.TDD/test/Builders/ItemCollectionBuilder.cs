using System;

namespace E02.TDD.test.Builders
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

        internal ItemCollectionBuilder WithItem(Item item)
        {
            items.Add(item);
            return this;
        }

        public ItemCollection Build()
        {
            return items;
        }
    }
}