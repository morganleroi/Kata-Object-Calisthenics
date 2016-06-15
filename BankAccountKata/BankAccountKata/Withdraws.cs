using System.Collections.Generic;

namespace BankAccountKata
{
    public class Withdraws
    {
        private readonly IEnumerable<Transaction> _withdraws;

        public Withdraws(IEnumerable<Transaction> withdraws)
        {
            _withdraws = withdraws;
        }

        public Amount Sum()
        {
            var amount = new Amount(0);
            foreach (var transaction in _withdraws)
            {
                amount += transaction.GetAmount();
            }

            return amount;
        }
    }
}