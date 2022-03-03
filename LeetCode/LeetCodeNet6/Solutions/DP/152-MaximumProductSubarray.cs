namespace LeetCodeNet6.Solutions.DP;

/*
Link: 
    https://leetcode.com/problems/maximum-product-subarray/
Notes:
    f(i) = max positive product of subarrays ending with arr[i]
    g(i) = min negative product of subarrays ending with arr[i]

    f(i) = max(f(i-1), 1) * arr[i] if arr[i] > 0 else g(i-1) * arr[i]
    f(0) = max(arr[0], 0)
    g(i) = max(f(i-1), 1) * arr[i] if arr[i] < 0 else g(i-1) * arr[i]
    g(0) = min(arr[0], 0)

    solution = max(f(i)) where i in 0..n
*/
public class Solution152
{
    public int MaxProduct(int[] nums)
    {
        if (nums.Length == 1) return nums[0];
        
        var positives = new int[nums.Length];
        var negatives = new int[nums.Length];

        if (nums[0] > 0) positives[0] = nums[0];
        else negatives[0] = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                positives[i] = Math.Max(positives[i - 1], 1) * nums[i];
                negatives[i] = negatives[i - 1] * nums[i];
            }
            else
            {
                positives[i] = negatives[i - 1] * nums[i];
                negatives[i] = Math.Max(positives[i - 1], 1) * nums[i];
            }
        }

        return positives.Max();
    }    
}