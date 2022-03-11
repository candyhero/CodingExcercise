namespace LeetCodeNet6.Solutions._TODOs;

/*
Link: 
    https://www.javatpoint.com/0-1-knapsack-problem

Notes: 
    f(i, j) be the max profit given j weight capacity taking weight i
    f(i, j) = max(f(k, j - weight[i])) + profit[i] where k in 0..i-1
    f(i, 0) = 0 
    f(0, j) = profit[0] if weight[j] <= k else 0 
    solution = max(f(i, j)) where i in 0..n-1
    
*/
public class Solution
{
    public void KnapSack(int k, int[] w, int[] v)
    {
        var n = w.Length;

        var dp = new int[n, k + 1];
        for (var j = 1; j <= k; j++)
        {
            dp[0, j] = w[0] <= k ? v[0] : 0;
        }

        var maxSoFar = new int[n];
        for (var i = 1; i < n; i++)
        {
            //f(i, j) = max(f(k, j - weight[i])) + profit[i] where k in 0..i-1
            for (var j = 1; j <= k; j++)
            {
                maxSoFar[i] = Math.Max(maxSoFar[i], dp[i - 1, j - w[i]]);
                dp[i, j] = maxSoFar[i];
            }
        }
    }
}