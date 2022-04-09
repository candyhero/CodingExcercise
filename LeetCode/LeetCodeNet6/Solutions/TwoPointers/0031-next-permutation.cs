namespace LeetCodeNet6.Solutions.TwoPointers;

/*
Link:
    https://leetcode.com/problems/next-permutation/ 
Notes:
    Example 
    [1,2,3]
    [1,3,2]
    [2,1,3]
    [2,3,1]
    [3,1,2]
    [3,2,1]
*/
public class Solution31
{
    public void NextPermutation(int[] nums)
    {
        if (nums.Length == 1) return;

        var nonDecIndex = nums.Length - 1;
        while (nonDecIndex > 0 && nums[nonDecIndex] <= nums[nonDecIndex - 1]) nonDecIndex--;

        if (nonDecIndex > 0)
        {
            var pivot = nonDecIndex - 1;
            var minIndex = nums.Length - 1;
            for (var i = nums.Length - 1; i >= nonDecIndex; i--)
            {
                if (nums[i] > nums[pivot])
                {
                    minIndex = i;
                    break;
                }
            }

            (nums[minIndex], nums[pivot]) = (nums[pivot], nums[minIndex]);
        }

        var lower = nonDecIndex;
        var upper = nums.Length - 1;
        while (lower < upper)
        {
            (nums[lower], nums[upper]) = (nums[upper], nums[lower]);
            lower++;
            upper--;
        }
    }
}