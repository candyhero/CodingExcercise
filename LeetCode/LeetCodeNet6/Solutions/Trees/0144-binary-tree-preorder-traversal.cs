using LeetCodeNet6.Solutions.Trees.Common;

namespace LeetCodeNet6.Solutions.Trees;

/*
Link:
    https://leetcode.com/problems/binary-tree-preorder-traversal/ 
*/
public class Solution144
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
        List<int> ret = new();
        PreorderTraversal(ret, root);
        return ret;
    }

    private void PreorderTraversal(List<int> ret, TreeNode root)
    {
        if (root == null) return;
        ret.Add(root.val);
        PreorderTraversal(ret, root.left);
        PreorderTraversal(ret, root.right);
    }

    public IList<int> PreorderTraversal_Iteration(TreeNode root)
    {
        List<int> ret = new();
        Stack<TreeNode> stack = new();
        stack.Push(root);
        while (stack.Count > 0)
        {
            var pop = stack.Pop();
            if (pop == null) continue;
            ret.Add(pop.val);
            stack.Push(pop.right);
            stack.Push(pop.left);
        }

        return ret;
    }
}