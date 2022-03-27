using System.Text;

namespace LeetCodeNet6.Solutions.Greedy;

/*
Link:
    https://leetcode.com/problems/smallest-string-with-a-given-numeric-value/
*/
public class Solution1663
{
    public string GetSmallestString(int n, int k)
    {
        // take as many z as possible
        var z = k / 26;
        // take as many a as possible 
        var a = n - z;
        // calculate remaining value
        var remainingValue = k - a - 26 * z;
                
        while (remainingValue < 0)
        {
            // change z into a, coz we take too many z
            z--;
            a++;
            remainingValue += 25; 
        }
        
        if (remainingValue > 0)
        {
            a--;
            remainingValue += 1;
        }

        var buffer = new StringBuilder(n);
        
        while (a-- > 0) buffer.Append('a');
        if (remainingValue > 0) buffer.Append((char) ('a' + remainingValue - 1));
        while (z-- > 0) buffer.Append('z');

        return buffer.ToString();
    }
}