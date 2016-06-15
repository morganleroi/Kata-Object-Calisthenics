using System.Collections.Generic;

namespace BankAccountKata
{
    public class Deposits
    {
        private readonly IEnumerable<Transaction> _transactions;

        public Deposits(IEnumerable<Transaction> transactions)
        {
            _transactions = transactions;
        }

        public Amount Sum()
        {
            var amount = new Amount(0);
            foreach (var transaction in _transactions)
            {
                amount += transaction.GetAmount();
            }

            return amount;
        }
    }
}