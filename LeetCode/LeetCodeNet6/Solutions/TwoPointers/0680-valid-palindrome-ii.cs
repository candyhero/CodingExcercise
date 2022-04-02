using System.Runtime.InteropServices;

namespace LeetCodeNet6.Solutions.TwoPointers;

/*
Link:
    https://leetcode.com/problems/valid-palindrome-ii/ 
*/
public class Solution680
{
    public bool ValidPalindrome(string s)
    {
        return ValidPalindrome(s, 0, s.Length - 1, false);
    }
    
    private bool ValidPalindrome(string s, int lower, int upper, bool hasBeenDeleted)
    {
        while (lower < upper)
        {
            if (s[lower] == s[upper])
            {
                lower++;
                upper--;
                continue;
            }

            if (hasBeenDeleted) return false;

            return ValidPalindrome(s, lower + 1, upper, true) 
                   || ValidPalindrome(s, lower, upper - 1, true);
        }

        return true;
    }
}