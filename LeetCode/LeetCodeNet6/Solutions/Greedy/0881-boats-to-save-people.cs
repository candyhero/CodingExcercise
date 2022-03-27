namespace LeetCodeNet6.Solutions.LinkedLists;

/*
Link:
    https://leetcode.com/problems/boats-to-save-people/ 
*/
public class Solution881
{
    public int NumRescueBoats(int[] people, int limit)
    {
        var sortedPeople = people.OrderBy(x => x).ToArray();
        int ret = 0, lower = 0, upper = sortedPeople.Length - 1;
        while (lower < upper)
        {
            if (sortedPeople[upper] + sortedPeople[lower] <= limit) lower++;
            upper--;
            ret++;
        }

        if (upper == lower) ret++;
        return ret;
    }
}