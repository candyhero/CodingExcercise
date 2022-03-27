namespace LeetCodeNet6.Solutions.Greedy;

/*
Link:
    https://leetcode.com/problems/broken-calculator/ 
*/
public class Solution991
{
    public int BrokenCalc(int startValue, int target)
    {
        if (target <= startValue) return startValue - target;

        var currentValue = target;
        var ret = 0;
        while (currentValue > startValue)
        {
            if (currentValue % 2 == 0)
            {
                currentValue /= 2;
            }
            else
            {
                currentValue += 1;
            }
            
            ret++;
        }

        ret += startValue - currentValue;
        return ret;
    }
}