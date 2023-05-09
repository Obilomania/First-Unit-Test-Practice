namespace Sparky
{
    public class BankAccount
    {
        public int balance { get; set; }
        public BankAccount()
        {
            balance = 0;
        }
        public bool Deposit(int amount)
        {
            balance += amount;
            return true;
        }
        public bool WithDraw(int amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            return false;
        }

        public int GetBalance()
        {
            return balance;
        }
    }
}
