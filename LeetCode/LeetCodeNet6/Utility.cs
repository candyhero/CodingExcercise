namespace LeetCodeNet6;

public static class Utility
{
    public static void Dump<T>(this IEnumerable<T> enumerable)
    {
        Console.WriteLine(string.Join(',', enumerable));
    }
}