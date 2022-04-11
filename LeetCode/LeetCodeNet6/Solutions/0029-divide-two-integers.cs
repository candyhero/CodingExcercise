namespace LeetCodeNet6.Solutions;

/*
Link:
    https://leetcode.com/problems/divide-two-integers/ 
*/
public class Solution29
{
    public int Divide(int dividend, int divisor)
    {
        long dvd = dividend > 0 ? dividend : -(long) dividend;
        long dvs = divisor > 0 ? divisor : -(long) divisor;
        
        if (dvd < dvs) return 0;
        
        var (quotient, reminder) = DivideLong(dvd, dvs);
        while (reminder >= dvs)
        {
            var (q, r) = DivideLong(reminder, dvs);
            reminder = r;
            quotient += q;
        }

        quotient = dividend > 0 && divisor > 0 || dividend < 0 && divisor < 0
            ? quotient
            : -quotient;
        
        return quotient switch
        {
            > int.MaxValue => int.MaxValue,
            < int.MinValue => int.MinValue,
            _ => (int) quotient
        };
    }

    private (long quotient, long reminder) DivideLong(long dividend, long divisor)
    {
        var accum = divisor << 1;
        long quotient = 1;
        while (accum <= dividend)
        {
            accum <<= 1;
            quotient <<= 1;
        }

        long reminder = dividend - (accum >> 1); 
        return (quotient, reminder);
    }
}