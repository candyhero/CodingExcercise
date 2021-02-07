package HackerRank.Array.ArrayManipulation;

import java.io.*;
import java.util.*;

public class Solution {
    static long arrayManipulation(int n, int[][] queries) {
        int[] arr = new int[n+2];
        Arrays.fill(arr, 0);
        for (int i = 0; i < queries.length; i++) {
            int[] query = queries[i];
            int p = query[0], q = query[1], k = query[2];
            arr[p] += k; 
            arr[q+1] -= k; 
        }

        long accumValue = 0, maxValue = 0;
        for (int i = 1; i <= n; i++) {
            accumValue += arr[i];
            maxValue = Math.max(accumValue, maxValue);
        }
        return maxValue;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String[] nm = scanner.nextLine().split(" ");

        int n = Integer.parseInt(nm[0]);

        int m = Integer.parseInt(nm[1]);

        int[][] queries = new int[m][3];

        for (int i = 0; i < m; i++) {
            String[] queriesRowItems = scanner.nextLine().split(" ");
            scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

            for (int j = 0; j < 3; j++) {
                int queriesItem = Integer.parseInt(queriesRowItems[j]);
                queries[i][j] = queriesItem;
            }
        }

        long result = arrayManipulation(n, queries);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
