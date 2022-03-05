namespace LeetCodeNet6.Solutions.DP;

/*
Link:
    https://leetcode.com/problems/delete-and-earn
*/
public class Solution740
{
    public int DeleteAndEarn(int[] nums)
    {
        if (nums.Length == 1) return nums[0];
        
        var scoreTable = nums.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Key * x.Count());
        var orderedKeys = scoreTable.Keys.OrderBy(x => x).ToList();

        var score0 = scoreTable[orderedKeys[0]];
        var score1 = scoreTable[orderedKeys[1]];
        
        var dp = new Dictionary<int, int>();
        dp[0] = score0;
        dp[1] = orderedKeys[1] - orderedKeys[0] == 1
            ? Math.Max(score1, dp[0])
            : dp[0] + score1;
        
        for (var i = 2; i < orderedKeys.Count; i++)
        {
            var score = scoreTable[orderedKeys[i]];
            dp[i] = orderedKeys[i] - orderedKeys[i - 1] == 1 
                ? Math.Max(dp[i - 2] + score, dp[i - 1])
                : dp[i - 1] + score;
        }

        return dp.Values.Max();
    }
}