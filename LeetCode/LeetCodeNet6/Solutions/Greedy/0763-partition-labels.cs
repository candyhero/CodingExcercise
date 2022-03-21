namespace LeetCodeNet6.Solutions.Greedy;

/*
Link:
    https://leetcode.com/problems/partition-labels/ 
*/
public class Solution763
{
    public IList<int> PartitionLabels(string s)
    {
        var intervals = new Dictionary<char, (int start, int end)>();
        for (var i = 0; i < s.Length; i++)
        {
            var key = s[i];
            var start = intervals.ContainsKey(key) ? intervals[key].start : i;
            intervals[key] = (start, i);
        }

        var ret = new List<(int start, int end)> { (0, 0) };
        var sortedIntervals = intervals.Values.OrderBy(x => x.start).ToArray();
        foreach (var interval in sortedIntervals)
        {
            var lastInterval = ret[^1];
            if (interval.start > lastInterval.end)
            {
                ret.Add((interval.start, interval.end));
            }
            else
            {
                ret[^1] = (lastInterval.start, Math.Max(lastInterval.end, interval.end));
            }
        }

        return ret.Select(x => x.end - x.start + 1).ToList();
    }
}