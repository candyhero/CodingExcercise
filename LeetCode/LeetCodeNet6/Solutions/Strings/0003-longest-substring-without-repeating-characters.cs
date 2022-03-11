namespace LeetCodeNet6.Solutions.Strings;

/*
Link:
    https://leetcode.com/problems/longest-substring-without-repeating-characters/
Notes: 
     given any string, we want to check on every substring that has no repeating characters
     
     for such substring, it must:
     - ends with char c, where c in [a-z]
     - starts with the prior occurence of char c before the ending char c, 
        or starts with the last repeating char, whichever latest
*/
public class Solution3
{
    public int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> lastCharIndex = new();
        int maxLength = 0, lastRepeatingCharIndex = -1;

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (lastCharIndex.ContainsKey(c))
            {
                lastRepeatingCharIndex = Math.Max(lastRepeatingCharIndex, lastCharIndex[c]);
            }
           
            maxLength = Math.Max(maxLength, i - lastRepeatingCharIndex);
            lastCharIndex[c] = i;
        }

        return maxLength;
    }
}