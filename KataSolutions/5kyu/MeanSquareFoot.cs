namespace Codewars
{
    public class SquareFoot
    {
        public static double Solution(int[] firstArray, int[] secondArray)
        {
            double sum = 0;
            for (var i = 0; i < secondArray.Length; i++)
            {
                var temp = Math.Pow((secondArray[i] - firstArray[i]),2);
                sum += temp;
            }
            return sum / secondArray.Length;
        }
    }
}