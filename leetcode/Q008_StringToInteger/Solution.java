package leetcode.Q008_StringToInteger;

class Solution {
    public int myAtoi(String s) {
        int index = 0, sign = 1;
        long value = 0;
        
        // Pre-process leading characters
        while (index < s.length()) {
            char c = s.charAt(index++); 
            if (c == ' ') { continue; }
            if (c == '+') { break; }
            if (c == '-') { sign = -1; break; }
            if(c < '0' || c > '9') { return 0; }
            value = c - '0'; 
            break;
        }

        while (index < s.length()) {
            char c = s.charAt(index++); 
            if(c < '0' || c > '9') { break; }

            value = value * 10 + (c - '0');
            if(value > Integer.MAX_VALUE) {
                return sign > 0 ? Integer.MAX_VALUE : Integer.MIN_VALUE;
            }
        }

        return sign * (int)value;
    }

    public static void main(String[] args) {
        Solution solution = new Solution();
        int value = solution.myAtoi("42");
        System.out.println(value);
    }
}