namespace LeetCodeNet6.Solutions.Heaps;

/*
Link:
    https://leetcode.com/problems/kth-largest-element-in-an-array/ 
*/
public class Solution213
{
    public int FindKthLargest(int[] nums, int k)
    {
        Array.Sort(nums);
        return nums[^k];
    }
}