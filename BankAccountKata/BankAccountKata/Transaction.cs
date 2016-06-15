namespace BankAccountKata
{
    public abstract class Transaction
    {
        private readonly Amount _amount;

        protected Transaction(Amount amount)
        {
            _amount = amount;
        }

        public Amount GetAmount()
        {
            return _amount;
        }
    }
}