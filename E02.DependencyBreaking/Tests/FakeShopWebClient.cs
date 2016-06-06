using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E03.DependencyBreaking.WebServiceContract;

namespace E03.DependencyBreaking.Tests
{
    class FakeShopWebClient : IShopClient
    {
        public PaymentResponse RequestPayment(PaymentRequest request)
        {
            return new PaymentResponse();
        }
    }
}
