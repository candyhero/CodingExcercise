namespace LeetCodeNet6.Solutions.DP;

/*
Link: 
    https://leetcode.com/problems/fibonacci-number/

Note: 
    f(n) be the n-th fibonacci number
    f(n) = f(n-1) + f(n-2)
    f(0) = 0
    f(1) = 1
    
    solution = f(n)
*/
public class Solution509
{
    public int Fib(int n)
    {
        if (n <= 1) return n;
        var dp = new int[n + 1];
        dp[1] = 1;

        for (var i = 2; i <= n; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }

        return dp[n];
    }
}