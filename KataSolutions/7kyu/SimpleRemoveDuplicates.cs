using System.Collections.Generic;
namespace Kata7kyu
{
    public class Solutions
    {
        public static int[] Solve(int[] arr)
        {
            return arr.Reverse().Distinct().Reverse().ToArray();
        }
    }
}