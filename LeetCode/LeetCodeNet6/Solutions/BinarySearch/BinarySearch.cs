namespace LeetCodeNet6.Solutions.BinarySearch;

public class BinarySearch
{
    // nums are sorted arrays with duplicates
    public int Search(int[] nums, int target)
    {
        var low = 0;
        var high = nums.Length - 1;

        while (low <= high)
        {
            var mid = low + (high - low) / 2;
            if (nums[mid] == target) return mid;
            else if (nums[mid] > target) high = mid - 1;
            else low = mid + 1;
        }

        return -1;
    }
    
    public int SearchLower(int[] nums, int target)
    {
        var low = 0;
        var high = nums.Length - 1;

        while (low < high)
        {
            var mid = low + (high - low) / 2;
            if (nums[mid] >= target) high = mid;
            else low = mid + 1;
        }

        if (low < nums.Length && nums[low] == target)
        {
            return low;
        }
        
        return -1;
    }
    
    public int SearchUpper(int[] nums, int target)
    {
        // [0, 1], 0 

        var low = 0;
        var high = nums.Length - 1;

        while (low < high)
        {
            var mid = low + (high - low + 1) / 2;
            if (nums[mid] <= target) low = mid;
            else high = mid - 1;
        }

        if (high >= 0 && nums[high] == target)
        {
            return high;
        }

        return -1;
    }
}

