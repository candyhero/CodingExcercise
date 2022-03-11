namespace LeetCodeNet6.Solutions.DP;

// https://leetcode.com/problems/coin-change/ 
// f(n) the fewest number of coins need to make up n amount
// f(n) = min(f(n-k)) + 1 where k in coins and n-k >= 0
// f(0) = 0
public class Solution322
{
    public int CoinChange(int[] coins, int amount) 
    {
        var dp = new int[amount + 1];
        
        for (var i = 1; i <= amount; i++)
        {
            var fewest = int.MaxValue;
            foreach (var k in coins)
            {
                if (i - k >= 0)
                {
                    fewest = Math.Min(fewest, dp[i - k]);
                }
            }

            dp[i] = fewest == int.MaxValue ? int.MaxValue : fewest + 1;
        }

        return dp[amount] == int.MaxValue ? -1 : dp[amount];
    }
}