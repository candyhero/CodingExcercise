namespace LeetCodeNet6.Solutions.Strings;

/**
Link:
    https://leetcode.com/problems/zigzag-conversion/
*/
public class Solution6 
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1) return s;
        var offset = 2 * numRows - 2;
        var buffer = new char[s.Length];
        var bufferIndex = 0; 
        for (var i = 0; i < numRows; i++)
        {
            var isCorner = i == 0 || i == numRows - 1;
            for (var j = 0; j + i < s.Length; j += offset)
            {
                buffer[bufferIndex++] = s[j + i];
                if (!isCorner && j + offset - i < s.Length) 
                {
                    buffer[bufferIndex++] = s[j + offset - i];
                }
            }
        }

        return new string(buffer);
    }
}