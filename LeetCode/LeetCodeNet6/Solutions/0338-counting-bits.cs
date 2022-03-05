namespace LeetCodeNet6.Solutions;

/*
Link:
    https://leetcode.com/problems/counting-bits/
*/
public class Solution338
{
    public int[] CountBits(int n)
    {
        var ret = new int[n + 1];
        ret[0] = 0;
        
        var carry = 1;
        for (var i = 1; i <= n; i++)
        {
            if (i >= carry * 2) carry *= 2;
            ret[i] = ret[i - carry] + 1;
        }

        return ret;
    }
}