namespace UnitTest_Demo.BankAccount
{
    public class BankAccount
    {
        public int balance { get; set; }
        private readonly ILogger _logger;
        public BankAccount(ILogger logger)
        {
            balance = 0;
            _logger = logger;
        }
        public bool Deposite(int amount)
        {
            balance += amount;
            _logger.Message("Deposite invoke");
            return true;
        }
        public bool Withdraw(int amount)
        {
            if(amount <= balance)
            {
                _logger.LogToDB("Withdraw Amount: " + amount.ToString());
                balance -= amount;
                return _logger.LogBalanceAfterWithdraw(balance);
            }
            return _logger.LogBalanceAfterWithdraw(balance - amount);
        }
        public int GetBalance()
        {
            return balance;
        }
    }
}
