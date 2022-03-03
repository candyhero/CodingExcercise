namespace LeetCodeNet6.Solutions;

/*
Link: 
    https://leetcode.com/problems/is-subsequence/
*/
public class Solution392
{
    public bool IsSubsequence(string s, string t)
    {
        if (string.IsNullOrEmpty(s)) return true;

        var ti = 0;
        for (var si = 0; si < s.Length && ti < t.Length; si++)
        {
            if (s[si] == t[ti]) ti++;
        }

        return ti == t.Length;
    }
}