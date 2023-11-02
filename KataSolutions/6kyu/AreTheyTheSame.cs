using System.Diagnostics.Metrics;

namespace Codewars
{
    public class AreTheySame
    {
        public static bool Comp(int[] a, int[] b)
        {
            if (a == null || b == null) return false;
            var result = a.Select(x => x * x).OrderBy(x => x).SequenceEqual(b);
            return result;
        }
    }
}