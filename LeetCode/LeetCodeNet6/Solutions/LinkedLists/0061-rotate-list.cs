namespace LeetCodeNet6.Solutions.LinkedLists;

/*
Link:
    https://leetcode.com/problems/rotate-list/ 
*/
public class Solution61
{
    public ListNode? RotateRight(ListNode? head, int k)
    {
        if (head?.next is null || k == 0) return head; 
        
        var tail = head;
        var length = 1;
        while (tail?.next is not null)
        {
            tail = tail.next;
            length++;
        }
        
        if (k % length == 0) return head;
        
        var offset = length - k % length - 1; // offset for left rotation 

        var breakpoint = head; 
        while (offset-- > 0) breakpoint = breakpoint?.next;

        var ret = breakpoint!.next; 
        tail!.next = head;
        breakpoint.next = null;

        return ret;
    }
}