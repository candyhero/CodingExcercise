using System.Text;
using LeetCodeNet6.Solutions.Trees.Common;

namespace LeetCodeNet6.Solutions.Trees;

/*
Link:
    https://leetcode.com/problems/serialize-and-deserialize-binary-tree/
Notes:
    1L2 1R3 3L4 3R5 
*/
public class Codec
{ 
    // Encodes a tree to a single string.
    public string serialize(TreeNode root)
    {
        Queue<TreeNode> queue = new();
        List<int?> ret = new();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var pop = queue.Dequeue();
            if (pop != null)
            {
                ret.Add(pop.val);
                queue.Enqueue(pop.left);
                queue.Enqueue(pop.right);
            }
            else
            {
                ret.Add(null);
            }
        }

        for (var i = ret.Count - 1; i >= 0; i--)
        {
            if (ret[i] == null)
            {
                ret.RemoveAt(i);
            }
            else
            {
                break;
            }
        }
        
        var sb = new StringBuilder();
        var prefix = '[';
        foreach (var num in ret)
        {
            sb.Append(prefix);
            if (num == null)
            {
                sb.Append("null");
            }
            else
            {
                sb.Append(num);
            }

            prefix = ',';
        }
        
        sb.Append(']');
        return sb.ToString();
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data)
    {
        var values = data
            .Substring(1, data.Length - 2)
            .Split(',')
            .Select(x => x == "null" ? null : int.Parse(x) as int?)
            .ToList();

        if (values.Count == 0) return null;

        var root = new TreeNode((int) values[0]);
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        for (var i = 1; i < values.Count; i += 2)
        {
            var pop = queue.Dequeue();
            pop.left = GetChild(values, i, queue);
            pop.right = GetChild(values, i + 1, queue);
        }
        
        return root;
    }

    private TreeNode GetChild(List<int?> values, int index, Queue<TreeNode> queue)
    {
        if (index >= values.Count || values[index] == null) return null;
        var child = new TreeNode((int) values[index]);
        queue.Enqueue(child);
        return child;
    }
}