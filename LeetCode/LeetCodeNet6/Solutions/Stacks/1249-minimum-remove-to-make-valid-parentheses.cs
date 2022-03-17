namespace LeetCodeNet6.Solutions.Stacks;

/*
Link:
    https://leetcode.com/problems/minimum-remove-to-make-valid-parentheses/ 
*/
public class Solution1249
{
    public string MinRemoveToMakeValid(string s)
    {
        Stack<int> stack = new();
        HashSet<int> removeSet = new();

        for (int i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (c == '(')
            {
                stack.Push(c);
            }
            else if (c == ')')
            {
                bool tryPop = stack.TryPop(out _);
                if (!tryPop) removeSet.Add(i);
            }
        }
                
        removeSet.UnionWith(stack);

        var tokens = s.Where((_, i) => !removeSet.Contains(i)).ToArray();
        return new string(tokens);
    }
}