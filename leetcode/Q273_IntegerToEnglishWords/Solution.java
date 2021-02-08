package leetcode.Q273_IntegerToEnglishWords;

import java.util.*;

class Solution {
    private static final String[] _units = { "", " Thousand", " Million", " Billion" };
    private static final String[] _zeroToNineteen = { 
        "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
        "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen",
    };
    private static final String[] _tens = {
        "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety",
    };

    public static void main(String[] args) {
        Solution solution = new Solution();
        System.out.println(solution.numberToWords(12345));
    }

    public String numberToWords(int num) {
        if(num == 0) { return _zeroToNineteen[0]; }

        List<Integer> tokens = new ArrayList<Integer>();
        while (num > 0) {
            tokens.add(num % 1000);
            num /= 1000;
        }

        List<String> buffer = new ArrayList<String>();
        for (int i = tokens.size() - 1; i >= 0; i--) {
            int token = tokens.get(i);
            if (token == 0) { continue; }
            buffer.add(translateIntToWords(token, _units[i]));
        }
        return String.join(" ", buffer);
    }

    // 0 < value < 1000
    private String translateIntToWords(int value, String unit) {
        List<String> buffer = new ArrayList<String>();

        int hundred = value / 100;
        if (hundred > 0) {
            buffer.add(_zeroToNineteen[hundred]);
            buffer.add("Hundred");
        }

        value %= 100;
        if (value > 0 && value < 20) { buffer.add(_zeroToNineteen[value]); }
        if (value >= 20) {
            buffer.add(_tens[value / 10]);
            int one = value % 10;
            if (one > 0) { buffer.add(_zeroToNineteen[one]); }
        }
        return String.join(" ", buffer) + unit; 
    }
}
