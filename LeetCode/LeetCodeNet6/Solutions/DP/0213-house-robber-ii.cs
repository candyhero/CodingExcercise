namespace LeetCodeNet6.Solutions.DP;

/*
Link: 
    https://leetcode.com/problems/house-robber-ii/
Notes: 
    
*/
public class Solution213
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 1) return nums[0];
        return Math.Max(RobHelper(nums.Skip(1).ToArray()), RobHelper(nums.SkipLast(1).ToArray()));
    }
    
    private int RobHelper(int[] nums)
    {
        if (nums.Length == 1) return nums[0];
        
        var ret = new int[nums.Length];
        ret[0] = nums[0];
        ret[1] = Math.Max(nums[0], nums[1]);
        for (var i = 2; i < nums.Length; i++)
        {
            ret[i] = Math.Max(ret[i - 1], ret[i - 2] + nums[i]);
        }

        return ret.Max();
    }
}