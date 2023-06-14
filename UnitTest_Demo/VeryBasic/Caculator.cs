namespace UnitTest_Demo.VeryBasic
{
    public class Caculator
    {
        public List<int> listNumber = new List<int>();
        public int AddNumber(int a, int b)
        {
            return a + b;
        }

        public bool IsOddNumber(int a)
        { 
            return a % 2 != 0;
        }

        public List<int> GetOddRange(int min, int max)
        {
            listNumber.Clear();
            for(int i = min; i <= max; i++)
            {
                if(i%2 != 0)
                {
                    listNumber.Add(i);
                }
            }
            return listNumber;
        }
    }
}
