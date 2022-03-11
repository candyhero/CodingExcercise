namespace LeetCodeNet6.Solutions.DP;

/*
Link:
    https://leetcode.com/problems/jump-game-ii/
Notes:
    f(n) be the min number of steps taking to reach position n
    f(n) = min(f(i)) where i + arr[i] >= n
    f(0) = 0 
*/
public class Solution45 
{
    public int Jump(int[] nums)
    {
        var dp = new int[nums.Length];
        dp[0] = 0;

        for (var i = 1; i < nums.Length; i++)
        {
            var min = int.MaxValue; 
            for (var j = 0; j < i; j++)
            {
                if (j + nums[j] >= i && dp[j] < min)
                {
                    min = dp[j];
                }
            }

            dp[i] = min + 1;
        }

        return dp[^1];
    }
}