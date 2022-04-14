using System.Text;

namespace LeetCodeNet6.Solutions.Trees.Common;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int x)
    {
        val = x;
    }
    
    public TreeNode(int x, TreeNode left, TreeNode right)
    {
        val = x;
        this.left = left;
        this.right = right;
    }
    
    public void ToDisplay()
    {
        var buffer = new StringBuilder(50);
        PrintTreeHelper(buffer, this, string.Empty, string.Empty);
        Console.WriteLine(buffer.ToString());
    }
    
    private void PrintTreeHelper(StringBuilder buffer, TreeNode node, string prefix, string childrenPrefix)
    {
        buffer.Append(prefix);
        var nodeValue = node.val.ToString();
        buffer.Append(nodeValue);
        buffer.Append(Environment.NewLine);

        if (node.left != null)
        {
            PrintTreeHelper(buffer, node.left, childrenPrefix + "├── ", childrenPrefix + "│   ");
        }

        if (node.right != null)
        {
            PrintTreeHelper(buffer, node.right, childrenPrefix + "└── ", childrenPrefix + "    ");
        }
    }
}