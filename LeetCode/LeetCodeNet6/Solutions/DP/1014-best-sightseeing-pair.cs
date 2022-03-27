namespace LeetCodeNet6.Solutions.DP;

/*
Link:
    https://leetcode.com/problems/best-sightseeing-pair/ 
Notes:
        
*/
public class Solution1014
{
    public int MaxScoreSightseeingPair(int[] values)
    {
        var dp = new int[values.Length];
        dp[0] = values[0];
        var temp = values[0];
        for (var i = 1; i < values.Length; i++)
        {
            dp[i] = temp + values[i] - i;
            temp = Math.Max(temp, values[i] + i);
        }
        
        return dp.Max();
    }
}