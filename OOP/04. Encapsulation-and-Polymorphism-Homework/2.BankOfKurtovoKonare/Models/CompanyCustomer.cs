using System;


namespace _2.BankOfKurtovoKonare.Models
{
    public class CompanyCustomer : Customer
    {
        public CompanyCustomer(string name)
            : base(name)
        {
            this.DepositRateMinDuration = 2;
            this.MortgageRateMinDuration = 12;
        }
    }
}
