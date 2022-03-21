namespace LeetCodeNet6.Solutions.Stacks;

/*
Link:
    https://leetcode.com/problems/remove-duplicate-letters/
*/
public class Solution316
{
    public string RemoveDuplicateLetters(string s)
    {
        Dictionary<char, int> charFreq = GetCharFreq(s);
        Stack<char> stack = new();
        
        stack.Push(s[0]);
        charFreq[s[0]] -= 1;
        
        for (int i = 1; i < s.Length; i++)
        {
            var c = s[i];
            if (!stack.Contains(c)) 
            {
                var p = stack.Peek();
                while (p > c && p != default)
                {
                    if (charFreq[p] > 0) stack.Pop();
                    else break; 
                    stack.TryPeek(out p);
                }

                stack.Push(c);
            }

            charFreq[c] -= 1;
        }

        var tokens = stack.Reverse().ToArray();
        return new string(tokens);
    }

    private Dictionary<char,int> GetCharFreq(string s)
    {
        var ret = new Dictionary<char, int>();
        foreach (var c in s)
        {
            ret[c] = ret.GetValueOrDefault(c, 0) + 1;
        }

        return ret;
    }
}