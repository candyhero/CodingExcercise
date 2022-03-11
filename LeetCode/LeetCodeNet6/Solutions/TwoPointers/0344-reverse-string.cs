namespace LeetCodeNet6.Solutions.TwoPointers;

/*
Link:
    https://leetcode.com/problems/reverse-string/
*/
public class Solution344
{
    public void ReverseString(char[] s)
    {
        var lower = 0;
        var upper = s.Length - 1;
        char temp = ' ';

        while (lower < upper)
        {
            temp = s[lower];
            s[lower++] = s[upper];
            s[upper--] = temp;
        }
    }
}