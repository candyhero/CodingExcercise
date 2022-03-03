using System.Text;

namespace LeetCodeNet6.Solutions;

/*
Link: 
    https://leetcode.com/problems/multiply-strings/
*/ 
public class Solution43
{
    public string Multiply(string num1, string num2)
    {
        var multiplier = ToByteArray(num1);
        var multiplicand = ToByteArray(num2);
        
        var ret = new byte[multiplier.Length + multiplicand.Length];
        for (var pow = 0; pow < multiplicand.Length; pow++)
        {
            var product = Multiply(multiplier, multiplicand[pow]);
            Add(ret, product, pow);
        }

        return ConvertToString(ret);
    }

    private string ConvertToString(byte[] ret)
    {
        RemoveLeadingZeros(ref ret);
        for (var i = 0; i < ret.Length; i++)
        {
            ret[i] += (byte) '0';
        }

        Array.Reverse(ret);
        return Encoding.ASCII.GetString(ret);
    }

    private void RemoveLeadingZeros(ref byte[] ret)
    {
        // start from most significant bit
        var zeroCount = 0;
        for (var i = ret.Length - 1; i >= 0; i--)
        {
            if (ret[i] > 0) break;
            zeroCount++;
        }

        if (zeroCount == ret.Length)
        {
            Array.Resize(ref ret, 1);
        }
        else if (zeroCount > 0)
        {
            Array.Resize(ref ret, ret.Length - zeroCount);
        }
    }

    private byte[] ToByteArray(string s) 
    {
        var bytes = Encoding.ASCII.GetBytes(s);
        Array.Reverse(bytes);
        for (var i = 0; i < bytes.Length; i++)
        {
            bytes[i] -= (byte) '0';
        }

        return bytes;
    }

    private void Add(byte[] ret, byte[] addend, int pow)
    {
        for (var i = 0; i < addend.Length; i++)
        {
            var sum = ret[pow + i] + addend[i];
            if (sum >= 10)
            {
                ret[pow + i] = (byte) (sum - 10);
                ret[pow + i + 1] += 1;
            }
            else
            {
                ret[pow + i] = (byte) sum;
            }
        }
    }

    private byte[] Multiply(byte[] num, byte digit)
    {
        var ret = new byte[num.Length + 1];
        for (var i = 0; i < num.Length; i++)
        {
            var product = num[i] * digit + ret[i];
            if (product >= 10)
            {
                ret[i] = (byte) (product % 10);
                ret[i + 1] += (byte) (product / 10);
            }
            else
            {
                ret[i] = (byte) product;
            }
        }

        return ret;
    }
}