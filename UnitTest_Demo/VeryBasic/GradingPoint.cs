namespace UnitTest_Demo.VeryBasic
{
    public class GradingPoint
    {
        public int Score { get; set; }
        public int BehaviorScore { get; set; }
        public string GetGrade()
        {
            switch(Score, BehaviorScore)
            {
                case (> 90,  >70):
                {
                    return "A";
                }
                case ( > 80, > 60):
                {
                    return "B";
                }
                case ( > 60, > 40):
                {
                    return "C";
                }     
            }
            return "F";
        }
    }
}
