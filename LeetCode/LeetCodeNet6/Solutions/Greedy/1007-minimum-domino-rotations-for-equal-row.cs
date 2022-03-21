namespace LeetCodeNet6.Solutions.Greedy;

/*
Link:
    https://leetcode.com/problems/minimum-domino-rotations-for-equal-row/
*/
public class Solution1007
{
    public int MinDominoRotations(int[] tops, int[] bottoms)
    {
        int n = tops.Length;
        Dictionary<int, int> counter = new();
        for (int i = 0; i < n; i++)
        {
            counter[tops[i]] = counter.GetValueOrDefault(tops[i], 0) + 1;
            if (tops[i] != bottoms[i])
            {
                counter[bottoms[i]] = counter.GetValueOrDefault(bottoms[i], 0) + 1;
            }
        }

        var target = counter.FirstOrDefault(x => x.Value == n).Key;
        if (target == 0) return -1;

        var topCount = tops.Count(x => x == target);
        var bottomCount = bottoms.Count(x => x == target);
        return n - Math.Max(topCount, bottomCount);
    }
}