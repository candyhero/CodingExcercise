namespace LeetCodeNet6.Solutions.BinarySearch;

/*
Link:
    https://leetcode.com/problems/split-array-largest-sum/ 
Notes:
    think again, how to binary search
*/
public class Solution410 
{
    public int SplitArray(int[] nums, int m)
    {
        long max = 0, sum = 0;
        foreach (var num in nums)
        {
            sum += num;
            if (num > max) max = num;
        }
        
        if (m == 1) return (int) sum;
        
        long lower = max, upper = sum;
        while (lower <= upper)
        {
            long mid = (upper + lower) / 2;
            if (IsValid(mid, nums, m)) upper = mid - 1;
            else lower = mid + 1;
        }

        return (int) lower;
    }

    private bool IsValid(long target, int[] nums, int m)
    {
        int count = 1;
        long total = 0;
        foreach (var num in nums)
        {
            total += num;
            if (total <= target) continue;
            
            total = num;
            count++;

            if (count > m) return false;
        }

        return true;
    }
}