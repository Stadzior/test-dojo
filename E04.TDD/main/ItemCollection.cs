using System.Collections.Generic;

namespace E02.TDD.test
{
    internal class ItemCollection : List<Item>
    {
        public static ItemCollection Empty()
        {
            return new ItemCollection();
        }
    }
}