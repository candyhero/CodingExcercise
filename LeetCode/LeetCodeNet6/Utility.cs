using LeetCodeNet6.Solutions.LinkedLists;

namespace LeetCodeNet6;

public static class Utility
{
    public static void Dump<T>(this IEnumerable<T> enumerable)
    {
        Console.WriteLine(string.Join(',', enumerable));
    }
    
    public static void Print<T>(this IEnumerable<T> enumerable)
    {
        Console.WriteLine(string.Join(',', enumerable));
    }

    public static void Print(this ListNode l)
    {
        while (l != null)
        {
            Console.Write(l.val);
            Console.Write(',');
            l = l.next;
        }
    }

    public static ListNode ToLinkedList(this IEnumerable<int> l)
    {
        var enumerable = l as int[] ?? l.ToArray();
        return !enumerable.Any()
            ? null
            : new ListNode(enumerable.First(), enumerable.Skip(1).ToLinkedList());
    }

    public static T LowerBound<T>(this T me, T bound) where T : IComparable
    {
        return me.CompareTo(bound) > 0 ? me : bound;
    }

    public static T UpperBound<T>(this T me, T bound) where T : IComparable
    {
        return me.CompareTo(bound) < 0 ? me : bound;
    }

    public static T Bound<T>(this T me, T lower, T upper) where T : IComparable
    {
        return me.LowerBound(lower).UpperBound(upper);
    }

    public static T[] Slice<T>(this T[] source, int start, int end)
    {
        if (end < 0)
        {
            end = source.Length + end;
        }

        var len = end - start;

        var res = new T[len];
        for (var i = 0; i < len; i++)
        {
            res[i] = source[i + start];
        }

        return res;
    }
}