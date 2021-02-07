package HackerRank.ProblemSolving.TimeConversion;

import java.io.*;
import java.math.*;
import java.text.*;
import java.util.*;
import java.util.regex.*;

public class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static String timeConversion(String s) {
        
        int periodIndex = s.length() - 2;
        String periodString = s.substring(periodIndex);
        String timeString = s.substring(0, periodIndex);
        String[] timeTokens = timeString.split(":");
        int hh = Integer.parseInt(timeTokens[0]) % 12;

        if (periodString.equals("PM")) {
            hh += 12;
        }
        return String.format("%02d:%s:%s", hh, timeTokens[1], timeTokens[2]);
    }

    public static void main(String[] args) throws IOException {

        String result = timeConversion("12:01:00PM");
        System.out.println(result);
    }
}
