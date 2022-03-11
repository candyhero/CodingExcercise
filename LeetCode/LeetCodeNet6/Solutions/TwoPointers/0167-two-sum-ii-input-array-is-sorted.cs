namespace LeetCodeNet6.Solutions.TwoPointers;

/*
Link: 
    https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
*/
public class Solution167
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var lower = 0;
        var upper = numbers.Length - 1;

        while (lower < upper)
        {
            var sum = numbers[lower] + numbers[upper];
            if (sum > target) upper--;
            else if (sum < target) lower++;
            else break;
        }

        return new[] { lower + 1, upper + 1 }; 
    }
}