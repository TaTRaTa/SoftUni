using System;

namespace _2.BankOfKurtovoKonare.Models
{
    using Interfaces;

    public abstract class Account
    {
        
        public Account(ICustomer customer, decimal ballance, double interesetrate)
        {
            this.Customer = customer;
            this.Balance = ballance;
            this.InterestRate = interesetrate;
        }

        public ICustomer Customer { get; set; }
        public decimal Balance { get; set; }
        public double InterestRate { get; }

        public void Deposit(decimal sum)
        {
           
            this.Balance += sum;
        }

        public virtual decimal CalculateIntereset(int months) =>
            this.Balance * (1 + (decimal)(this.InterestRate * months));

        public override string ToString() =>
            $"{this.Customer.Name} Ballance: {this.Balance:C}";
    }
}
