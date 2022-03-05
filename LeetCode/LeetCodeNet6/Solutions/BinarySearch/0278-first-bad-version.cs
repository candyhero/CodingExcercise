namespace LeetCodeNet6.Solutions;

/*
Link: 
    https://leetcode.com/problems/first-bad-version/
*/
public class Solution278 
{
    public int FirstBadVersion(int n)
    {
        return Helper(1, n);
    }
    
    public int Helper(int lower, int upper)
    {
        if (lower == upper) return lower;
        var mid = lower + (upper - lower) / 2;
        return IsBadVersion(mid) 
            ? Helper(1, mid) 
            : Helper(mid + 1, upper);
    }

    private bool IsBadVersion(int version)
    {
        return true;
    }
}