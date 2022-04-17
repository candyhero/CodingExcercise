using LeetCodeNet6.Solutions.Trees.Common;

namespace LeetCodeNet6.Solutions.Trees;

/*
Link:
    https://leetcode.com/problems/increasing-order-search-tree/ 
*/
public class Solution897
{
    public TreeNode IncreasingBST(TreeNode root)
    {
        List<int> inOrderList = new();
        InorderTraversal(inOrderList, root);
        var ret = new TreeNode(0);
        var cur = ret;
        foreach (var val in inOrderList)
        {
            cur.right = new TreeNode(val);
            cur = cur.right;
        }

        return ret.right;
    }

    private void InorderTraversal(List<int> ret, TreeNode root)
    {
        if (root == null) return;
        InorderTraversal(ret, root.left);
        ret.Add(root.val);
        InorderTraversal(ret, root.right);
    }
}