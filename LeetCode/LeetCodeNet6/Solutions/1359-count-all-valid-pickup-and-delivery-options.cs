namespace LeetCodeNet6.Solutions;

/*
Link: 
    https://leetcode.com/problems/count-all-valid-pickup-and-delivery-options/
    
Notes:
    
    n = 1, 1 insertion point -> 
        f(1) = 1
    n = 2, 3 insertion point * possible combinations -> 
        f(2) = (3c1 + 3c2) * f(1) = (3 + 3) * 1 = 6
    n = 3, 5 insertion point * possible combinations -> 
        f(3) = (5c1 + 5c2) * f(2) = (5 + 10) * 6 = 90 
    ...
    let m = 2n-1
    f(n) = (mc1 + mc2) * f(n - 1)
    
    Simplify mc1 + mc2:
        mc1 = m
        mc2 = m! / (2! (m-2)!) = m(m-1)/2
        thus mc1 + mc2 = m(m+1)/2
    Sub m with 2n-1:
        mc1+mc2 = (2n-1)2n/2 = n(2n-1)
    ...      
    Solution:
    f(n) = n(2n-1) * f(n-1)
    f(1) = 1
*/
public class Solution1359
{
    private const int Mod = 1000000007;

    public int CountOrders(int n)
    {
        var dp = new int[n + 1];
        dp[1] = 1;

        for (var i = 2; i <= n; i++)
        {
            long result = i * (2 * i - 1);
            result *= dp[i - 1];
            Console.WriteLine($"{i}, {result}");
            dp[i] = (int) (result % Mod);
        }

        return dp[n];
    }
}