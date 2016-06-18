using System;

namespace E02.TDD.main
{
    public class Payment
    {

        public Payment(DateTime paymentDate)
        {
            Date = paymentDate;
        }

        public Payment() {
            Date = DateTime.Now;
        }

        public DateTime Date { get;}
        public double PercentDiscount { get; set; }
        public double Value { get; set; }
    }
}