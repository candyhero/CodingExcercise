namespace LeetCodeNet6.Solutions.TwoPointers;

/*
Link:
    https://leetcode.com/problems/rotate-array/
    
Note: 
    O(1) space
*/
public class Solution189 
{
    public void Rotate(int[] nums, int k)
    {
        if (k % nums.Length == 0) return; 
        
        var hcf = GetHcf(nums.Length, k);
        // Console.WriteLine(hcf);
        
        var offset = nums.Length - k % nums.Length; // left rotation lol coz easier to write
        
        for (var i = 0; i < hcf; i++)
        {
            var buffer = nums[i];
            var bufferIndex = i;
            for (var j = 1; j < nums.Length / hcf; j++)
            {
                var index = (i + j * offset) % nums.Length;
                // Console.WriteLine($"{buffer} | {bufferIndex}, {index}");
                nums[bufferIndex] = nums[index];
                bufferIndex = index; 
            }

            nums[bufferIndex] = buffer;
        }
    }

    private int GetHcf(int a, int b)
    {
        var val1 = a;
        var val2 = b;

        while (true)
        {
            if (val1 > val2 && val1 % val2 > 0) val1 %= val2; 
            else if (val2 > val1 && val2 % val1 > 0) val2 %= val1; 
            else break;
        }

        return Math.Min(val1, val2);
    }
}