using System;


namespace _2.BankOfKurtovoKonare.Models
{
    public class IndividualCustomer : Customer
    {
        public IndividualCustomer(string name)
            : base(name)
        {
            this.DepositRateMinDuration = 3;
            this.MortgageRateMinDuration = 6;
        }
    }
}
