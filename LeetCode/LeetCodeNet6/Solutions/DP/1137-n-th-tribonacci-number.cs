namespace LeetCodeNet6.Solutions.DP;

/*
Link: 
    https://leetcode.com/problems/n-th-tribonacci-number/

Note: 
    f(n) be the n-th tribonacci number
    f(n) = f(n-1) + f(n-2) + f(n-3)
    f(0) = 0
    f(1) = 1
    f(2) = 2
    
    solution = f(n)
*/
public class Solution1137
{
    public int Tribonacci(int n) 
    {
        if (n == 0) return 0;
        var dp = new int[n + 1];
        dp[1] = 1;
        dp[2] = 1;

        for (var i = 3; i <= n; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2] + dp[i - 3];
        }

        return dp[n];
    }
}