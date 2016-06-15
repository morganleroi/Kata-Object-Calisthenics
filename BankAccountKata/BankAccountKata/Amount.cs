namespace BankAccountKata
{
    public class Amount
    {
        private readonly int _amount;

        public Amount(int value)
        {
            _amount = value;
        }

        public static Amount operator +(Amount c1, Amount x)
        {
            return new Amount(c1._amount + x._amount);
        }

        public static Amount operator -(Amount c1, Amount x)
        {
            return new Amount(c1._amount - x._amount);
        }

        public int GetValue()
        {
            return _amount;
        }
    }
}