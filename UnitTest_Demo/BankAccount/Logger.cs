namespace UnitTest_Demo.BankAccount
{
    public interface ILogger
    {
        void Message(string message);
        bool LogToDB(string message);
        bool LogBalanceAfterWithdraw(int balanceAfterWithdraw);
    }
    public class Logger : ILogger
    {
        public bool LogBalanceAfterWithdraw(int balanceAfterWithdraw)
        {
           if(balanceAfterWithdraw > 0)
           {
                Console.WriteLine("Success");
                return true;
           }
           Console.WriteLine("Failure");
           return false;
        }

        public bool LogToDB(string message)
        {
            Console.WriteLine(message);
            return true;
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
