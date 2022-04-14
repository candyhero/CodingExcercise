using LeetCodeNet6.Solutions.Trees.Common;

namespace LeetCodeNet6.Solutions.Trees;

/*
Link:
    https://leetcode.com/problems/binary-tree-postorder-traversal/ 
*/
public class Solution145
{
    public IList<int> PostorderTraversal(TreeNode root)
    {
        List<int> ret = new();
        PostorderTraversal(ret, root);
        return ret;
    }

    private void PostorderTraversal(List<int> ret, TreeNode root)
    {
        if (root == null) return;
        PostorderTraversal(ret, root.left);
        PostorderTraversal(ret, root.right);
        ret.Add(root.val);
    }
}