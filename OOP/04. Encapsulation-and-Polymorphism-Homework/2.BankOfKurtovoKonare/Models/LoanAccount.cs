using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankOfKurtovoKonare.Models
{
    using Interfaces;

    public class LoanAccount : Account
    {
        public LoanAccount(ICustomer customer, decimal ballance, double interesetrate)
            : base(customer, ballance, interesetrate)
        {
        }

        public override decimal CalculateIntereset(int months)
        {
            if (months <= this.Customer.DepositRateMinDuration)
            {
                return this.Balance;
            }

            return base.CalculateIntereset(months - this.Customer.DepositRateMinDuration);
        }
    }
}
