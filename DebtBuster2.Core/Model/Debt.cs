using System;

namespace DebtBuster.Core
{
    public class Debt
    {
        public decimal InterestRate { get; set; }
        public DateTime TermEnd { get; set; }
        public DateTime TermStart { get; set; }
        public string LenderName { get; set; }
        public string Description { get; set; }
        public decimal AmountOwing { get; set; }
        public decimal RepaymentAmount { get; set; }
        public PaymentPeriod PaymentPeriod { get; set; }
    }
}
