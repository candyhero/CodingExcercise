namespace LeetCodeNet6.Solutions.Matrice;

/*
Link:
    https://leetcode.com/problems/spiral-matrix-ii/ 
*/
public class Solution59
{
    public int[][] GenerateMatrix_(int n)
    {
        var ret = new int[n][];
        for (var i = 0; i < n; i++) ret[i] = new int[n];

        var currentValue = 1;
        for (var i = 0; i < (n + 1) / 2; i++)
        {
            currentValue = GenerateSpiral(ret, i, n, currentValue);
        }

        return ret;
    }

    private int GenerateSpiral(int[][] ret, int level, int n, int currentValue)
    {
        var oppLevel = n - level - 1;
        if (level == oppLevel)
        {
            ret[level][level] = currentValue++;
            return currentValue;
        }

        for (var j = level; j < oppLevel; j++) ret[level][j] = currentValue++;
        for (var i = level; i < oppLevel; i++) ret[i][oppLevel] = currentValue++;
        for (var j = oppLevel; j > level; j--) ret[oppLevel][j] = currentValue++;
        for (var i = oppLevel; i > level; i--) ret[i][level] = currentValue++;
        return currentValue;
    }
}