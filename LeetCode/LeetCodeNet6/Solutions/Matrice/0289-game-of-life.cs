namespace LeetCodeNet6.Solutions.Matrice;

/*
Link:
    https://leetcode.com/problems/game-of-life/ 
*/
public class Solution289
{
    public void GameOfLife(int[][] board)
    {
        var (m, n) = (board.Length, board[0].Length);
        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                var liveNeighborCount = GetLiveNeighborCount(board, i, j);
                if (board[i][j] == 0 && liveNeighborCount == 3)
                {
                    board[i][j] += 1 << 1;
                }
                else if (board[i][j] == 1 && liveNeighborCount is < 2 or > 3)
                {
                }
                else
                {
                    board[i][j] += board[i][j] << 1;
                }
            }
        }

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                board[i][j] >>= 1;
            }
        }
    }

    private int GetLiveNeighborCount(int[][] board, int i, int j)
    {
        var ret = 0;
        if (i > 0) ret += board[i - 1][j] % 2;
        if (i < board.Length - 1) ret += board[i + 1][j] % 2;
        if (j > 0) ret += board[i][j + 1] % 2;
        if (j < board[0].Length - 1) ret += board[i][j - 1] % 2;
        if (i > 0 && j > 0) ret += board[i - 1][j - 1] % 2;
        if (i < board.Length - 1 && j > 0) ret += board[i + 1][j - 1] % 2;
        if (i > 0 && j < board[0].Length - 1) ret += board[i - 1][j + 1] % 2;
        if (i < board.Length - 1 && j < board[0].Length - 1) ret += board[i + 1][j + 1] % 2;
        return ret;
    }
}