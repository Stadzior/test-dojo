using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E03.DependencyBreaking
{
    public class Product
    {
        public Product()
        {
        }
        public Product(double price,double quantity,double minWholesaleQuantity = 0)
        {
            Price = price;
            Quantity = quantity;
            MinWholesaleQuantity = minWholesaleQuantity;
        }
        public double Quantity { get; set; }

        public double MinWholesaleQuantity { get; set; }

        public double Price { get; set; }
    }
}
