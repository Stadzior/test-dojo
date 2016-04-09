using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03.DependencyBreaking.Tests
{
    class TestableShoppingClass : ShoppingCart
    {
        public override void SaveCart(ShoppingCart cart)
        {

        }
        public override void AddGifts(double total)
        {
            
        }
    }
}
