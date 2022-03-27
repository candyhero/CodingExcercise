namespace LeetCodeNet6.Solutions.BinarySearch;

/*
Link:
    https://leetcode.com/problems/the-k-weakest-rows-in-a-matrix/ 
*/
public class Solution1337
{
    public int[] KWeakestRows(int[][] mat, int k)
    {
        return mat
            .Select((x, i) => (Strength(x), i))
            .OrderBy(x => x)
            .Select(x => x.i)
            .Take(k)
            .ToArray();
    }

    private int Strength(int[] row)
    {
        var lower = 0;
        var upper = row.Length - 1;

        while (lower <= upper)
        {
            var mid = lower + (upper - lower) / 2;
            if (row[mid] == 0) upper = mid - 1;
            else lower = mid + 1;
        }

        return lower - 1;
    }
}