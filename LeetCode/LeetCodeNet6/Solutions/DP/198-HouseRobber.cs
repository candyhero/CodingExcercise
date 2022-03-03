namespace LeetCodeNet6.Solutions.DP;

/*
Link: 
    https://leetcode.com/problems/house-robber/
Notes:
    f(i) = max money so far u can rob at house i
    f(i) = max(f(i-1), f(i-2)+arr[i]) 
    f(0) = arr[0]
    f(1) = max(arr[0], arr[1])

    solution = f(n-1)
*/
public class Solution198
{
    public int Rob(int[] nums)
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