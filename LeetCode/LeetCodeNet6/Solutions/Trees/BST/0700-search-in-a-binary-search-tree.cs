using LeetCodeNet6.Solutions.Trees.Common;

namespace LeetCodeNet6.Solutions.Trees.BST;

/*
Link:
    https://leetcode.com/problems/search-in-a-binary-search-tree/ 
*/
public class Solution700
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        if (root == null) return null;
        if (root.val == val) return root;
        if (root.val < val) return SearchBST(root.right, val);
        return SearchBST(root.left, val);
    }
}