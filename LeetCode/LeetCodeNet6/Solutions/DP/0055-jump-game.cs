namespace LeetCodeNet6.Solutions.DP;

/*
Link: 
    https://leetcode.com/problems/jump-game/

Notes:
    f(i) = any(f(j) && arr[j] >= i - j) where j is 0..i-1
    f(0) = true

    solution = f(n - 1)
*/
public class Solution55
{
    public bool CanJump(int[] nums)
    {
        var ret = new bool[nums.Length];
        ret[0] = true;
        for (var i = 1; i < nums.Length; i++)
        {
            for (var j = 0; j < i; j++)
            {
                if (ret[j] && nums[j] >= i - j)
                {
                    ret[i] = true;
                    break;
                }
            }
        }
        
        return ret[^1];
    }
}