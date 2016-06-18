using System;
using E02.TDD.main;
namespace E02.TDD.test.Builders
{
    class PaymentBuilder : IBuilder<Payment>
    {
        private Payment payment;

        public PaymentBuilder()
        {
            payment = new Payment();
        }
        public Payment Build()
        {
            return payment;
        }

        public static PaymentBuilder Payment()
        {
            return new PaymentBuilder();
        }

        internal PaymentBuilder WithDate(DateTime date)
        {
            payment.Date = date;
            return this;
        }
    }
}
