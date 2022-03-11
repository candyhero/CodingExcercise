namespace LeetCodeNet6.Solutions.TwoPointers;

/*
Link:
    https://leetcode.com/problems/remove-nth-node-from-end-of-list/
*/
public class Solution19 
{
    public ListNode? RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode? p1 = head, p2 = head;
        while (n-- > 0) p2 = p2?.next;

        if (p2 is null) return head.next;
        
        while (p2.next is not null)
        {
            p1 = p1?.next;
            p2 = p2.next;
        }

        p1!.next = p1.next?.next;

        return head;
    }    
}