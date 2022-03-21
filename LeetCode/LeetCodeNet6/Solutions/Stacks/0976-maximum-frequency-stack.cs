using System.Collections;

namespace LeetCodeNet6.Solutions.Stacks;

/*
Link:
    https://leetcode.com/problems/maximum-frequency-stack/
Note:
    1. Two order:
        Frequency order > stack order
        For each distinct element, 
*/
public class Solution976 
{
    
}

public class FreqStack
{
    private Dictionary<int, int> freqMap = new();
    private List<Stack<int>> freqStacks = new() { new Stack<int>() };
    
    public FreqStack() 
    {
    }
    
    public void Push(int val)
    {
        var freq = freqMap.GetValueOrDefault(val, 0) + 1;
        freqMap[val] = freq;
        if (freqStacks.Count == freq) freqStacks.Add(new Stack<int>());
        freqStacks[freq].Push(val);
    }
    
    public int Pop()
    {
        var lastIndex = freqStacks.Count - 1;
        var freqStack = freqStacks[lastIndex];
        var val = freqStack.Pop();
        
        if (freqStack.Count == 0) freqStacks.RemoveAt(lastIndex);
        freqMap[val] -= 1;

        return val;
    }
}