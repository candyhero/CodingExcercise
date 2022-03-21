namespace LeetCodeNet6.Solutions.DP;

/*
Link: 
    https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/
Notes: 
    f(n) be profit for buying on n - 1th day and selling on nth day
    f(n) = arr[n] - arr[n-1] if > 0 else 0
    f(0) = 0
    solution = sum(f(n)) where n in 0..n-1
*/
public class Solution122 
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length <= 1) return 0;
        var ret = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            var profit = prices[i] - prices[i - 1];
            if (profit > 0) ret += profit;
        }
        
        return ret;
    }
}