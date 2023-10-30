namespace Codewars
{
    public class ReturnNegative
    {
        public int MakeNegative(int number)
        {
            if (number <= 0)
                return number;
            else
                return Int32.Parse($"-{number}");
        }

        // public static int MakeNegative(int n) => n < 0 ? n : -n;
        // return -Math.Abs(number);

    }
}