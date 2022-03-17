namespace LeetCodeNet6.Solutions.Stacks;

/*
Link:
    https://leetcode.com/problems/score-of-parentheses/
*/
public class Solution856
{
    public int ScoreOfParentheses(string s)
    {
        Stack<int> stack = new();
        stack.Push(0);
        
        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (c == '(')
            {
                stack.Push(0);
            }
            else if (c == ')')
            {
                var score = stack.Pop();
                var upperScore = stack.Pop();
                upperScore += score == 0 ? 1 : score * 2;
                stack.Push(upperScore);
            }
        }
        
        return stack.Pop();
    }
}