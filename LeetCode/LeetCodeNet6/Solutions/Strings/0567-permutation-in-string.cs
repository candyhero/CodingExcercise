namespace LeetCodeNet6.Solutions.Strings;

/*
Link:
    https://leetcode.com/problems/permutation-in-string/
    
Notes:
*/
public class Solution567
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length) return false;

        var targetMap = s1.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
        var distance = s1.Length;
        
        for (var i = 0; i < s2.Length; i++)
        {
            if (i >= s1.Length)
            {
                var disqualifiedChar = s2[i - s1.Length];
                if (targetMap.ContainsKey(disqualifiedChar))
                {
                    targetMap[disqualifiedChar] += 1;
                    if (targetMap[disqualifiedChar] > 0) distance++; // valid character
                }
            }
            
            var c = s2[i];
            if (targetMap.ContainsKey(c))
            {
                if (targetMap[c] > 0) distance--; // valid character
                targetMap[c] -= 1;
                
                if (distance == 0 && targetMap[c] == 0) return true;
            }
        }
        
        return false;
    }
}