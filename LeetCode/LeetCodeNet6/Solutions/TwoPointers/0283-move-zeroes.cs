namespace LeetCodeNet6.Solutions.Arrays;

/*
Link:
    https://leetcode.com/problems/move-zeroes
*/
public class Solution283
{
    public void MoveZeroes(int[] nums)
    {
        var retIndex = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0) continue;
            nums[retIndex] = nums[i];
            if (i > retIndex++) nums[i] = 0;
        }
    }
}