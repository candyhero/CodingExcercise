namespace LeetCodeNet6.Solutions.BinarySearch;

public class Solution287 
{
    public int FindDuplicate(int[] nums)
    {
        var lower = 1;
        var upper = nums.Length - 1;

        while (lower < upper)
        {
            var mid = lower + (upper - lower) / 2;
            var count = nums.Count(num => num <= mid);

            if (count > mid)
            {
                upper = mid;
            }
            else
            {
                lower = mid + 1;
            }
        }

        return lower;
    }
}