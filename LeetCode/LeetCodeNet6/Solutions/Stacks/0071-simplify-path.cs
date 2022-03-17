namespace LeetCodeNet6.Solutions.Stacks;

/*
Link:
    https://leetcode.com/problems/simplify-path/
*/
public class Solution71
{
    public string SimplifyPath(string path)
    {
        Stack<string> stack = new();
        foreach (var token in path.Split('/'))
        {
            if (token.Length == 0 || token.Equals(".")) continue;
            if (token.Equals(".."))
            {
                if (stack.Count > 0) stack.Pop();
            }
            else stack.Push(token);
        }

        var tokens = stack.Reverse();
        return $"/{string.Join('/', tokens)}";
    }
}