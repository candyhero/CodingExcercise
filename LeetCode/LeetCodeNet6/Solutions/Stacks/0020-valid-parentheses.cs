namespace LeetCodeNet6.Solutions.Stacks;

/*
Link:
    https://leetcode.com/problems/valid-parentheses/ 
*/
public class Solution20
{
    private readonly HashSet<char> _OpenBrackets = new() { '(', '[', '{' };
    
    public bool IsValid(string s)
    {
        Stack<char> stack = new();
        
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (_OpenBrackets.Contains(c)) stack.Push(c);
            else if (IsValidBracketPair(stack, c)) stack.Pop();
            else return false;
        }

        return stack.Count == 0;
    }

    private bool IsValidBracketPair(Stack<char> stack, char c)
    {
        bool tryPeek = stack.TryPeek(out var peek);
        if (!tryPeek) return false; 
        
        if (c == ')' && peek == '(') return true;
        if (c == ']' && peek == '[') return true;
        if (c == '}' && peek == '{') return true;
        return false;
    }
}