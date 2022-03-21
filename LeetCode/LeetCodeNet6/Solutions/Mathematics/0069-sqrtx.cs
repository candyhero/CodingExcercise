namespace LeetCodeNet6.Solutions.Mathematics;

/*
Link:
    https://leetcode.com/problems/sqrtx/ 
*/
public class Solution69
{
    public int MySqrt(int x) 
    {
        long ret = 0;
        while (ret * ret <= x) ret++;
        return (int) ret - 1;
    }

    // ver 2
    // public int MySqrt(int x)
    // {
    //     int ret = 0, square = 0, offset = 1;
    //     while (x - square >= offset)
    //     {
    //         ret++;
    //         square += offset;
    //         offset += 2;
    //     }
    //
    //     return ret;
    // }
}