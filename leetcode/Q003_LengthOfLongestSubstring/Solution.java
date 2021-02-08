package leetcode.Q003_LengthOfLongestSubstring;

import java.util.HashMap;
import java.util.Map;

public class Solution {
    public static void main(String[] args) {
        Solution solution = new Solution();
        int l = solution.lengthOfLongestSubstring("abba");
        System.out.println(l);
    }

    public int lengthOfLongestSubstring(String s) {
        // 0 or 1 characters
        if (s.length() < 2) { return s.length(); }
        
        Map<Character, Integer> map = new HashMap<>();
        int lastRepeatIndex = -1;
        int max = 1; 
        for (int i = 0; i < s.length(); ++i) {
            char c = s.charAt(i);
            System.out.println(String.format("%c, %d, %d", c, lastRepeatIndex, max));
            if (map.containsKey(c)) {
                // e.g. 
                // abcabc, i = 5, c = 'a', lastCharIndex = 2, lastRepeatIndex = 1
                // abccba, i = 5, c = 'a', lastCharIndex = 0, lastRepeatIndex = 3
                // abccba, i = 1, c = 'b', lastCharIndex = 0, lastRepeatIndex = 0
                // aabbcc, i = 5, c = 'c', lastCharIndex = 4, lastRepeatIndex = 3
                int lastCharIndex = map.get(c);
                if (lastCharIndex > lastRepeatIndex) {
                    max = Math.max(max, i - lastCharIndex);
                }
                lastRepeatIndex = Math.max(lastCharIndex, lastRepeatIndex);
            }
            if (i > lastRepeatIndex) {
                max = Math.max(max, i - lastRepeatIndex);
            }
            map.put(c, i);
            System.out.println(String.format("%c, %d, %d", c, lastRepeatIndex, max));
        }
        return max;
    }
}