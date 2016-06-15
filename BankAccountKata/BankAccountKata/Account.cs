namespace BankAccountKata
{
    public class Account
    {
        private readonly Transactions _transactions = new Transactions();

        public void Depose(Amount amount)
        {
            _transactions.Depose(amount);
        }

        public Transactions GetTransactions()
        {
            return _transactions;
        }

        public Balance Balance()
        {
            return new Balance(_transactions);
        }

        public void Withdraw(Amount amount)
        {
            _transactions.Withdraw(amount);
        }
    }
}