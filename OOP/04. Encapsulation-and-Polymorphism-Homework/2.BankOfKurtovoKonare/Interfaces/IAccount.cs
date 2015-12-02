namespace _2.BankOfKurtovoKonare.Interfaces
{
    public interface IAccount
    {
        ICustomer Customer { get; }

        decimal Ballance { get; }

        double InterestRate { get; }

        decimal CalculateIntereset(int months);
    }
}