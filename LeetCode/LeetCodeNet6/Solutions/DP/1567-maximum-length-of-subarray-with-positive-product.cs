using System.Diagnostics;

namespace LeetCodeNet6.Solutions.DP;

/*
Link:
    https://leetcode.com/problems/maximum-length-of-subarray-with-positive-product/ 
*/
public class Solution1567
{
    public int GetMaxLen(int[] nums)
    {
        int positive = 0, negative = 0;

        if (nums[0] > 0) positive = 1;
        else if (nums[0] < 0) negative = 1;

        int ret = positive;
        for (int i = 1; i < nums.Length; i++)
        {
            var newPositive = positive + 1;
            var newNegative = negative > 0 ? negative + 1 : 0;
            switch (nums[i])
            {
                case > 0:
                    positive = newPositive;
                    negative = newNegative;
                    break;
                case < 0:
                    positive = newNegative;
                    negative = newPositive;
                    break;
                default:
                    positive = 0;
                    negative = 0;
                    break;
            }

            ret = Math.Max(ret, positive);
        }

        return ret;
    }
}