namespace LeetCodeNet6.Solutions.BinarySearch;

/*
Link:
    https://leetcode.com/problems/search-a-2d-matrix/ 
*/
public class Solution74
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        // find row
        var lower = 0;
        var upper = matrix.Length - 1;
        while (lower <= upper)
        {
            var mid = lower + (upper - lower) / 2;
            if (matrix[mid][0] <= target && target <= matrix[mid][^1])
            {
                return BinarySearch(matrix[mid], target);
            }
            else if (matrix[mid][0] > target)
            {
                upper = mid - 1;
            }
            else
            {
                lower = mid + 1;
            }
        }

        return false;
    }

    private bool BinarySearch(int[] row, int target)
    {
        var lower = 0;
        var upper = row.Length - 1;
        while (lower <= upper)
        {
            var mid = lower + (upper - lower) / 2;
            if (row[mid] == target) return true;
            else if (row[mid] > target) upper = mid - 1;
            else lower = mid + 1;
        }

        return false;
    }
}