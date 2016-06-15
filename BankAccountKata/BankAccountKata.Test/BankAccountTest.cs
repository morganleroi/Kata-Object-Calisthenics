using NFluent;
using NUnit.Framework;

namespace BankAccountKata.Test
{
    public class BankAccountTest
    {
        [Test]
        public void Can_depose_money_on_my_account()
        {
            var account = new Account();
            account.Depose(new Amount(1000));

            var transactions = account.GetTransactions();
            Check.That(transactions.Count()).IsEqualTo(1);
            Check.That(account.Balance().Get().GetValue()).IsEqualTo(1000);
        }

        [Test]
        public void Can_withdraw_money_on_my_account()
        {
            var account = new Account();
            account.Depose(new Amount(1000));

            account.Withdraw(new Amount(450));

            var transactions = account.GetTransactions();
            Check.That(transactions.Count()).IsEqualTo(2);
            Check.That(account.Balance().Get().GetValue()).IsEqualTo(550);
        }
    }
}