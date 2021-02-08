package leetcode.Q014_LongestCommonPrefix;

class Solution {
    public String longestCommonPrefix(String[] strs) {
        if (strs.length == 0) { return ""; }
        if (strs.length == 1) { return strs[0]; }
        
        String shortest = strs[0];
        for (int i = 1; i < strs.length; i++) {
            shortest = shortest.length() < strs[i].length() ? shortest : strs[i];
        }

        StringBuffer sb = new StringBuffer();
        for (int i = 0; i < shortest.length(); i++) {
            char c = shortest.charAt(i);
            for (int j = 0; j < strs.length; j++) {
                if (c != strs[j].charAt(i)) { return sb.toString(); }
            }
            sb.append(c);
        }
        return sb.toString();
    }
}
