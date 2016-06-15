using System.Collections.Generic;
using System.Linq;

namespace BankAccountKata
{
    public class Transactions
    {
        private readonly IList<Transaction> _transactions = new List<Transaction>();
         
        public void Depose(Amount amount)
        {
            _transactions.Add(new Deposit(amount));
        }

        public int Count()
        {
            return _transactions.Count;
        }

        public Deposits GetAllDeposit()
        {
            return new Deposits(_transactions.Where(x => x is Deposit));
        }

        public void Withdraw(Amount amount)
        {
            _transactions.Add(new Withdraw(amount));
        }

        public Withdraws GetAllWithdraw()
        {
            return new Withdraws(_transactions.Where(x => x is Withdraw));
        }
    }
}