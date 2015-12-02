using System;


namespace _2.BankOfKurtovoKonare.Models
{
    using Interfaces;

    public class MortgageAccount : Account
    {
        public MortgageAccount(ICustomer customer, decimal ballance, double interesetrate)
            : base(customer, ballance, interesetrate)
        {
        }

        public override decimal CalculateIntereset(int months)
        {
            if (months <= this.Customer.MortgageRateMinDuration)
            {
                return base.CalculateIntereset(months / 2);
            }

            return base.CalculateIntereset(months);
        }
    }
}
