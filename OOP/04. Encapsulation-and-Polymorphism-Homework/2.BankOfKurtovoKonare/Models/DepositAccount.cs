

namespace _2.BankOfKurtovoKonare.Models
{
    using System;
    using Interfaces;
    using Models;

    public class DepositAccount : Account, IWithdraw
    {
        public DepositAccount(ICustomer customer, decimal ballance, double interesetrate)
            : base(customer, ballance, interesetrate)
        {
        }

        public void Withdraw(decimal sum)
        {           
            this.Balance -= sum;
        }

        public override decimal CalculateIntereset(int months)
        {
            if (this.Balance < 1000)
            {
                return this.Balance;
            }

            return base.CalculateIntereset(months);
        }
    }
}
