using LeetCodeNet6.Solutions.Trees.Common;

namespace LeetCodeNet6.Solutions.Trees;

/*
Link:
    https://leetcode.com/problems/convert-bst-to-greater-tree/ 
*/
public class Solution538
{
    public TreeNode ConvertBST(TreeNode root)
    {
        GetSum(root, 0);
        return root;
    }

    private int GetSum(TreeNode root, int currentSum)
    {
        if (root is null) return currentSum;
        currentSum = GetSum(root.right, currentSum);
        currentSum += root.val;
        root.val = currentSum;
        return GetSum(root.left, currentSum);
    }
}