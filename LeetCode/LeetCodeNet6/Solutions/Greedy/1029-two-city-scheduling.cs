namespace LeetCodeNet6.Solutions.Greedy;

/*
Link:
    https://leetcode.com/problems/two-city-scheduling/ 
*/
public class Solution1029
{
    public int TwoCitySchedCost(int[][] costs) 
    {
        Array.Sort(costs, CompareCostDiff);
        var ret = 0;
        for (var i = 0; i < costs.Length / 2; i++)
        {
            ret += costs[i][0];
        }

        for (var i = costs.Length / 2; i < costs.Length; i++)
        {
            ret += costs[i][1];
        }

        return ret;
    }

    public int CompareCostDiff(int[] cost1, int[] cost2)
    {
        var diff1 = cost1[0] - cost1[1];
        var diff2 = cost2[0] - cost2[1];
        return diff1 - diff2;
    }
}