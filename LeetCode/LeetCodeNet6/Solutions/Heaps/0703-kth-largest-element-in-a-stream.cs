namespace LeetCodeNet6.Solutions.Heaps;

/*
Link:
    https://leetcode.com/problems/kth-largest-element-in-a-stream/ 
*/
public class KthLargest
{
    private int _k;
    private PriorityQueue<int, int> _pq;

    public KthLargest(int k, int[] nums)
    {
        _k = k;
        
        var items = nums.Select(x => (x, x));
        _pq = new PriorityQueue<int, int>(items);
        
        while (_pq.Count > _k) _pq.Dequeue();
    }
    
    public int Add(int val)
    {
        _pq.Enqueue(val, val);
        while (_pq.Count > _k) _pq.Dequeue();
        return _pq.Peek();
    }
}