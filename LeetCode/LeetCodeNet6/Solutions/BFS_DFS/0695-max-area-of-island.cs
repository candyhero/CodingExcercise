namespace LeetCodeNet6.Solutions.BFS_DFS;

/*
Link:
    https://leetcode.com/problems/max-area-of-island/
*/
public class Solution695
{
    public int MaxAreaOfIsland(int[][] grid)
    {
        int m = grid.Length, n = grid[0].Length;
        int maxIslandArea = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] == 1)
                {
                    var islandArea = Helper(grid, i, j, m, n);
                    maxIslandArea = Math.Max(maxIslandArea, islandArea);
                }
            }
        }

        return maxIslandArea;
    }

    private int Helper(int[][] grid, int i, int j, int m, int n)
    {
        if (i < 0 || i >= m) return 0;
        if (j < 0 || j >= n) return 0;
        if (grid[i][j] == 0) return 0;
        grid[i][j] = 0;
        return 1
               + Helper(grid, i - 1, j, m, n)
               + Helper(grid, i + 1, j, m, n)
               + Helper(grid, i, j - 1, m, n)
               + Helper(grid, i, j + 1, m, n);
    }
}