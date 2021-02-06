package leetcode.Q007_ReverseInteger;

class Solution {
    public int reverse(int x) {
        int sign = Integer.signum(x), value = x * sign; 
        long result = 0;
        while (value > 0) {
            result = result * 10 + value % 10;
            value /= 10;
        }
        return result > Integer.MAX_VALUE ? 0 : sign * (int)result;
    }

    public static void main(String[] args) {
        Solution solution = new Solution();
        // int result = solution.reverse(1534236469);
        System.out.println(-12%10);
    }
}