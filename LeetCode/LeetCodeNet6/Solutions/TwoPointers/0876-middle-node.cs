namespace LeetCodeNet6.Solutions.TwoPointers;

/*
Link:
    https://leetcode.com/problems/middle-of-the-linked-list/
*/

public class Solution876
{
    public ListNode MiddleNode(ListNode head)
    {
        ListNode? p1 = head, p2 = head;
        while (p2?.next is not null)
        {
            p1 = p1?.next;
            p2 = p2?.next?.next;
        }

        return p1!;
    }
}