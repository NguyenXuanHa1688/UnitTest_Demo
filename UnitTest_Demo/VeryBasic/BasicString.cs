namespace UnitTest_Demo.VeryBasic
{
    public class BasicString
    {
        public int NumberOfHello = 0;
        public string Message { get; set; }
        public string MyName(string firstName, string lastName)
        {
            if(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentException("Invalid Input");
            }
            Message =  "Hello my name is " + firstName + " " + lastName;
            NumberOfHello = 1;
            return Message;
        }
        public OriginalString GetString()
        {
            if (NumberOfHello == 0)
            {
                return new childAString();
            }
            return new childBString();
        }
    }
    public class OriginalString { }
    public class childAString : OriginalString { }
    public class childBString : OriginalString { }
}
