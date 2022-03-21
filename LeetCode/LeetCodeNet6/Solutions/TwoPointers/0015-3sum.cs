namespace LeetCodeNet6.Solutions.TwoPointers;

/*
Link:
    https://leetcode.com/problems/3sum/
*/
public class Solution15
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        if (nums.Length < 3) return new List<IList<int>>();

        var retSet = new HashSet<HashSet<int>>();
        var sorted = nums.OrderBy(x => x).ToArray();
        for (int i = 0; i < sorted.Length; i++)
        {
            var target = -sorted[i];
            int low = i + 1, high = sorted.Length - 1;
            while (low < high)
            {
                var sum = sorted[low] + sorted[high];
                if (sum < target) low++;
                else if (sum > target) high--;
                else
                {
                    var set = new HashSet<int> { sorted[i], sorted[low], sorted[high] };
                    retSet.Add(set);
                    low++;
                    high++;
                }
            }
        }

        return retSet.Select(set => set.ToList()).Cast<IList<int>>().ToList();
    }
}