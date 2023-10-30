using System.Collections.Generic;
namespace Codewars
{
    public class RemoveDuplicates
    {
        public static int[] Solve(int[] arr) => arr.Reverse().Distinct().Reverse().ToArray();
    }
}