namespace LeetCodeNet6.Solutions.TwoPointers;

/*
Link:
    https://leetcode.com/problems/reverse-words-in-a-string-iii/
*/
public class Solution557
{
    public string ReverseWords(string s)
    {
        var tokens = s.Split(' ').Select(x => ReverseString(x)).ToArray();
        return string.Join(' ', tokens);
    }
    
    public string ReverseString(string str)
    {
        var s = str.ToCharArray();
        var lower = 0;
        var upper = s.Length - 1;
        char temp = ' ';

        while (lower < upper)
        {
            temp = s[lower];
            s[lower++] = s[upper];
            s[upper--] = temp;
        }

        return new string(s);
    }
}