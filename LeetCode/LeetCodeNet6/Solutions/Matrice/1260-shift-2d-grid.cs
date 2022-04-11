namespace LeetCodeNet6.Solutions.Matrice;

/*
Link:
    https://leetcode.com/problems/shift-2d-grid/ 
*/
public class Solution1260
{
    //
    public IList<IList<int>> ShiftGrid(int[][] grid, int k)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        var gridSize = m * n;
        
        var ret = new int[m][];
        for (var i = 0; i < m; i++)
        {
            ret[i] = new int[n];
        }
        
        for (var i = 0; i < gridSize; i++)
        {
            ret[(i + k) % gridSize / n][(i + k) % n] = grid[i / n][i % n];
        }

        return ret;
    }
    
    public IList<IList<int>> ShiftGridNoExtraSpace(int[][] grid, int k)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        var gridSize = m * n;
        k %= gridSize;
        if (k == 0 || k == gridSize) return grid;
        
        var hcf = GetHcf(gridSize, k);
        var lcm = gridSize * k / hcf;
        for (var i = 0; i < hcf; i++)
        {
            var lastIndex = lcm + i - k;
            var temp = grid[lastIndex % gridSize / n][lastIndex % n];
            for (var index = lastIndex; index >= k; index -= k)
            {
                var prevIndex = index - k;
                grid[index % gridSize / n][index % n] = grid[prevIndex % gridSize / n][prevIndex % n];
            }

            grid[i / n][i % n] = temp;
        }

        return grid;
    }

    private int GetHcf(int num1, int num2)
    {
        var mod = num1 > num2 
            ? num1 % num2 
            : num2 % num1;
        
        while (mod > 0)
        {
            if (num1 > num2)
            {
                num1 = mod; 
                mod = num2 % num1;
            }
            else
            {
                num2 = mod; 
                mod = num1 % num2;
            }
        }

        return Math.Min(num1, num2);
    }
}