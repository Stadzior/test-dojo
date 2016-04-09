using E03.DependencyBreaking.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E03.DependencyBreaking.WebServiceContract
{
    public class PaymentRequest
    {
        public PaymentRequest()
        {
            Total = double.NaN;
            Discount = double.NaN;
        }

        public PaymentRequest(double total,double discount)
        {
            Total = total;
            Discount = discount;
        }

        public double Total { get; set; }

        public double Discount { get; set; }
    }
}
