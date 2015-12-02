using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankOfKurtovoKonare
{
    using Interfaces;
    using Models;

    public static class ProgramMain
    {
        public static void Main()
        {
            ICustomer[] clients =
            {
                new IndividualCustomer("Pesho"),
                new IndividualCustomer("Gosho"),
                new CompanyCustomer("Soft Uni LTD"),
                new CompanyCustomer("Manchester United FC"),
            };

            var depositAcc = new DepositAccount(clients[0], 8955.33m, 0.005);
            var loanAcc = new LoanAccount(clients[1], 500m, 0.002);
            var mortgageAcc = new MortgageAccount(clients[2], 5m, 0.009);
            var depositAcc2 = new DepositAccount(clients[3], 159, 0.08);

            depositAcc.Withdraw(6000m);
            depositAcc2.Withdraw(54.22m);
            mortgageAcc.Deposit(15m);
            loanAcc.Deposit(5559.66m);

            try
            {
                depositAcc.Withdraw(500000000m);
            }
            catch (ArgumentException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }

            Console.WriteLine(depositAcc2);
            Console.WriteLine(mortgageAcc);

            Console.WriteLine(loanAcc + $" Interest rate: {loanAcc.CalculateIntereset(12):C}");
        }
    }
}
