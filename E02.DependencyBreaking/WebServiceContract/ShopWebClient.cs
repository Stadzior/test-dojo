using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E03.DependencyBreaking.WebServiceContract
{
    
    public class ShopWebClient : IShopClient
    {
        public PaymentResponse RequestPayment(PaymentRequest request)
        {
            return new PaymentResponse();
        }
    }
    
}
