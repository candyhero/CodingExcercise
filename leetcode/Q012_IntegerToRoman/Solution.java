package leetcode.Q012_IntegerToRoman;

class Solution {

    /**
     * 
     * @param int num 
     *      1 <= num <= 3999
     * 
     * @return String
     *      The roman number string that represents num    
     *      ('I', 'V', 'X', 'L', 'C', 'D', 'M')
     */
    public String intToRoman(int num) {
        StringBuffer sb = new StringBuffer();
        for (int i = 0; i < (num / 1000) % 5; i++) { sb.append('M'); }
        sb.append(convertDigitToRoman((num / 100) % 10, 'C', 'D', 'M'));
        sb.append(convertDigitToRoman((num / 10) % 10, 'X', 'L', 'C'));
        sb.append(convertDigitToRoman(num % 10, 'I', 'V', 'X'));
        return sb.toString();
    }

    private String convertDigitToRoman(int digit, char unit1, char unit5, char unit10) {
        switch (digit) {
            case 4:
                return new String(new char []{ unit1, unit5 }); 
            case 9:
                return new String(new char []{ unit1, unit10 }); 
            default:
                StringBuffer sb = new StringBuffer();
                if (digit >= 5) { sb.append(unit5); }
                for (int i = 0; i < digit % 5; i++) { sb.append(unit1); }
                return sb.toString();
        }
    }
}