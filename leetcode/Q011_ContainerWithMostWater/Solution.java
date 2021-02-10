package leetcode.Q011_ContainerWithMostWater;

class Solution {
    public int maxArea(int[] height) {
        int lowPtr = 0, highPtr = height.length - 1;
        int maxArea = highPtr * Math.min(height[lowPtr], height[highPtr]);
        while (lowPtr + 1 < highPtr) {
            if (height[lowPtr] < height[highPtr]) { lowPtr++; }
            else { highPtr--; }
            int newArea = (highPtr - lowPtr) * Math.min(height[lowPtr], height[highPtr]);
            maxArea = Math.max(maxArea, newArea);
        }
        return maxArea;
    }
}