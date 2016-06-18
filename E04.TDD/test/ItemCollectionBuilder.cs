using System;

namespace E02.TDD.test
{
    internal class ItemCollectionBuilder
    {
        private ItemCollection items;

        public ItemCollectionBuilder()
        {
            items = new ItemCollection();
        }

        internal ItemCollectionBuilder withItem(Item item)
        {
            items.Add(item);
            return this;
        }

        internal ItemCollection build()
        {
            return items;
        }
    }
}