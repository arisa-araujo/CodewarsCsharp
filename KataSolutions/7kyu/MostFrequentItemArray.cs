namespace Codewars
{
    public class MostFrequentItemArray
    {
        public static int ItemCount(int[] collection)
        {
            return collection.Length == 0 ? 0 : collection.GroupBy(x => x).Max(g => g.Count());
        }
    }
}