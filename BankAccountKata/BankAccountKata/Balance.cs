namespace BankAccountKata
{
    public class Balance
    {
        private readonly Transactions _transactions;

        public Balance(Transactions transactions)
        {
            _transactions = transactions;
        }

        public Amount Get()
        {
            var deposits = _transactions.GetAllDeposit();
            var withdraws = _transactions.GetAllWithdraw();
            return deposits.Sum() - withdraws.Sum();
        }
    }
}