using System.Formats.Asn1;

namespace LeetCodeNet6.Solutions.TwoPointers;

/*
Link:
    https://leetcode.com/problems/container-with-most-water/ 
*/
public class Solution11
{
    public int MaxArea(int[] height)
    {
        var lower = 0;
        var upper = height.Length - 1;
        var maxArea = 0;

        while (lower < upper)
        {
            var area = (upper - lower) * Math.Min(height[lower], height[upper]);
            if (area > maxArea) maxArea = area;
            
            if (height[lower] < height[upper]) lower++;
            else upper--;
        }

        return maxArea;
    }
}