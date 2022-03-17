namespace LeetCodeNet6.Solutions.Stacks;

/*
Link:
    https://leetcode.com/problems/validate-stack-sequences/
*/
public class Solution946
{
    public bool ValidateStackSequences(int[] pushed, int[] popped)
    {
        if (pushed.Length < popped.Length) return false;
        Stack<int> stack = new();
        var i = 0;
        foreach (var item in pushed)
        {
            stack.Push(item);
            while (stack.TryPeek(out var peek))
            {
                if (peek == popped[i])
                {
                    stack.Pop();
                    i++;
                }
                else
                {
                    break;
                }
            }
        }

        return stack.Count == 0;
    }
}