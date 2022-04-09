namespace LeetCodeNet6.Solutions;

/*
Link:
    https://leetcode.com/problems/top-k-frequent-elements/ 
*/
public class Solution347
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        List<HashSet<int>> frequencySets = new() { new HashSet<int>() }; // index = freq
        Dictionary<int, int> frequencyMap = new();
        foreach (var num in nums)
        {
            var frequency = frequencyMap.GetValueOrDefault(num, 0);
            if (frequencySets.Count == frequency + 1)
            {
                frequencySets.Add(new HashSet<int>());
            }

            frequencySets[frequency + 1].Add(num);
            frequencyMap[num] = frequency + 1;
        }

        return frequencySets.First(x => x.Count == k).ToArray();
    }
}