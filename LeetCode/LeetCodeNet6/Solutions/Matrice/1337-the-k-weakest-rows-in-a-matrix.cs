namespace LeetCodeNet6.Solutions.Matrice;

/*
Link:
    https://leetcode.com/problems/the-k-weakest-rows-in-a-matrix/ 
*/
public class Solution1337
{
    public int[] KWeakestRows(int[][] mat, int k)
    {
        return mat
            .Select((x, i) => (x.Sum(), i))
            .OrderBy(x => x)
            .Select(x => x.i)
            .Take(k)
            .ToArray();
    }
}