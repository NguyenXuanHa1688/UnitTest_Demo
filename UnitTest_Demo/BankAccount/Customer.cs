namespace UnitTest_Demo.BankAccount
{
    public class Customer
    {
        public int Discount = 15;
        public int OrderTotal { get; set; }
        public string GreetMessage { get; set; }
        public bool IsPlatinum { get; set; }
        public Customer()
        {
            IsPlatinum = false;
        }
        public string GreetAndCombineName(string firstName, string lastName)
        {
            if(string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("Invalid Name");
            }
            GreetMessage = "Hello "+ " " + firstName + " " + lastName;
            Discount = 20;
            return GreetMessage;
        }
        public CustomerTier GetCustomerTier()
        {
            if(OrderTotal < 100)
            {
                return new BasicCustomer();
            }
            return new PlatinumCustormer();
        }

        public class CustomerTier { }
        public class BasicCustomer : CustomerTier { }
        public class PlatinumCustormer : CustomerTier { }

    }
}
