namespace LeetCodeNet6;

public static class Utility
{
    public static void Print<T>(this IEnumerable<T> enumerable)
    {
        Console.WriteLine(string.Join(',', enumerable));
    }
}