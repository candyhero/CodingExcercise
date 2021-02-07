package leetcode.Q003_LengthOfLongestSubstring;

import java.util.HashMap;
import java.util.Map;

public class Solution {
    public int lengthOfLongestSubstring(String s) {
        if (s.length() < 2) {
            return s.length();
        }
        
        Map<Character, Integer> map = new HashMap<>();
        int lastRepeatedCharIndex = 0, lengthOfLongestSubstring = 1; 

        for (int i = 1; i < s.length(); ++i) {
            char c = s.charAt(i);
            
            // Is current char repeated?
            // Then currentLength = last length
            // update index then continue 
            if(map.containsKey(c)) {
                lastRepeatedCharIndex = map.get(c);
                continue;
            }
    
            // Is current char not repeated?
            // calculate length
            int currentSubstringLength = i - lastRepeatedCharIndex; 
            lengthOfLongestSubstring = Math.max(currentSubstringLength, lengthOfLongestSubstring);
            map.put(c, i);
        }
        return lengthOfLongestSubstring;
    }

    public static void main(String[] args) {
        Solution solution = new Solution();
        int l = solution.lengthOfLongestSubstring("pwwkew");
        System.out.println(l);
    }
}