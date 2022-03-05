namespace LeetCodeNet6.Solutions.DP;

/*
Link: 
    https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
Notes: 
    f(i) = max profit if u sell on day i
    f(i) = arr[i] - min(arr[0..i-1]) -> can store while looping
    f(0) = 0

    g(i) = max(f(i)) where i = 0..n-1
*/
public class Solution121
{
    public int MaxProfit(int[] prices)
    {
        var minSoFar = prices[0];
        var maxRet = 0;
        for (var i = 1; i < prices.Length; i++)
        {
            maxRet = Math.Max(prices[i] - minSoFar, maxRet);
            minSoFar = Math.Min(prices[i], minSoFar);
        }
        
        return maxRet;
    }
}