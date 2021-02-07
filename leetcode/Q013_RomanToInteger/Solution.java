package leetcode.Q013_RomanToInteger;


class Solution {
    public static void main(String[] args) {
        Solution solution = new Solution();
        int result = solution.romanToInt("MCMXCIV"); 
        System.out.println(result);   
    }

    /**
     * @param s
     *      1 <= s.length <= 15
     *      s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M')
     *      It is guaranteed that s is a valid roman numeral in the range [1, 3999]
     * 
     * @return int
     *      The integer value of roman number string s     
     */
    public int romanToInt(String s) {
        int lastCharValue = 0, result = 0; 

        // Yes, we go from right to left
        // because we always need the character on the right to determine
        // might as well as just go from the right to left
        for (int i = s.length() - 1; i >= 0; i--) {
            int currentCharValue = convertRomanCharToInt(s.charAt(i));

            // This comparison approach work only because of the precondition
            // that it can only be at most one smaller value on the left 
            result += (currentCharValue >= lastCharValue) 
                ? currentCharValue
                : -currentCharValue;
            lastCharValue = currentCharValue;
        }
        return result;
    }

    // Convert a single roman character into numeric value
    private int convertRomanCharToInt(char c) {
        switch (c) {
            case 'M': 
                return 1000;
            case 'D': 
                return 500;
            case 'C': 
                return 100;
            case 'L': 
                return 50;
            case 'X': 
                return 10;
            case 'V': 
                return 5;
            case 'I': 
                return 1;
            default:
                return 0;
        }
    } 
}