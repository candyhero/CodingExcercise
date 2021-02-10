package leetcode.Q042_TrappingRainWater;

class Solution {
    public int trap(int[] height) {
        if (height.length < 3) { return 0; }

        int lowPtr = 0, highPtr = height.length - 1;
        int lowHeight = height[lowPtr], highHeight = height[highPtr];
        
        int result = 0;
        while (lowPtr < highPtr) {
            if (lowHeight < highHeight) { 
                lowPtr++;
                if (height[lowPtr] > lowHeight) lowHeight = height[lowPtr]; 
                else result += lowHeight - height[lowPtr]; 
            }
            else { 
                highPtr--; 
                if (height[highPtr] > highHeight) highHeight = height[highPtr]; 
                else result += highHeight - height[highPtr]; 
            }
        }
        return result;
    }
}