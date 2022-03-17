namespace LeetCodeNet6.Solutions.BFS_DFS;

/*
Link:
    https://leetcode.com/problems/flood-fill/
*/
public class Solution733
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
    {
        var targetColor = image[sr][sc];
        Helper(image, sr, sc, targetColor, newColor);
        return image;
    }

    private void Helper(int[][] image, int sr, int sc, int targetColor, int newColor)
    {
        if (0 > sr || sr >= image.Length) return;
        if (0 > sc || sc >= image[0].Length) return;
        if (image[sr][sc] == newColor) return;
        if (image[sr][sc] != targetColor) return;

        image[sr][sc] = newColor;
        Helper(image, sr - 1, sc, targetColor, newColor);
        Helper(image, sr + 1, sc, targetColor, newColor);
        Helper(image, sr, sc - 1, targetColor, newColor);
        Helper(image, sr, sc + 1, targetColor, newColor);
    }
}