namespace UnitTest_Demo.BankAccount
{
    public interface ILogger
    {
        void Message(string message);
        bool LogToDB(string message);
        bool LogBalanceAfterWithdraw(int balanceAfterWithdraw);
        bool LogWithOutResult(string str, out string outString);
        bool LogWithRefObj(ref Customer customer);
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

        public bool LogWithOutResult(string str, out string outString)
        {
            outString = "Hello " + str;
            return true;
        }

        public bool LogWithRefObj(ref Customer customer)
        {
            return true;
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
