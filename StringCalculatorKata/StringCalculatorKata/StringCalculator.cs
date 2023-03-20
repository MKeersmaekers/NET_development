namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public static int Add(string empty)
        {
            if(empty == "")
            {
                return 0;
            } else if (empty.Count() == 1)
            {
                return int.Parse(empty);
            } else if (empty.Count() == 2)
            {
                return int.Parse(empty);
            } else
            { return int.Parse(empty); }
        }
    }
}