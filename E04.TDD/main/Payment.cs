using System;

namespace E02.TDD.main
{
    public class Payment
    {

        public Payment() {
            Date = DateTime.Now;
        }

        public DateTime Date { get; set; }
        public double PercentDiscount { get; set; }
        public double Total { get; set; }
        public double Value { get; set; }
    }
}