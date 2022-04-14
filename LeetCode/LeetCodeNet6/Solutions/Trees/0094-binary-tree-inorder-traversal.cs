using LeetCodeNet6.Solutions.Trees.Common;

namespace LeetCodeNet6.Solutions.Trees;

/*
Link:
    https://leetcode.com/problems/binary-tree-inorder-traversal/ 
*/
public class Solution94
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> ret = new();
        InorderTraversal(ret, root);
        return ret;
    }

    private void InorderTraversal(List<int> ret, TreeNode root)
    {
        if (root == null) return;
        InorderTraversal(ret, root.left);
        ret.Add(root.val);
        InorderTraversal(ret, root.right);
    }
}