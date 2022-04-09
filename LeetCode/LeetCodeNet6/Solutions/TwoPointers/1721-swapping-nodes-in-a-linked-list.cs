namespace LeetCodeNet6.Solutions.TwoPointers;

/*
Link:
    https://leetcode.com/problems/swapping-nodes-in-a-linked-list/ 
*/
public class Solution1721
{
    public ListNode SwapNodes(ListNode head, int k)
    {
        var p1 = head;
        var p2 = head;
        for (var i = 0; i < k - 1; i++)
        {
            p2 = p2.next;
        }

        var first = p2;
        while (p2.next != null)
        {
            p1 = p1.next;
            p2 = p2.next;
        }

        var second = p1;
        (first.val, second.val) = (second.val, first.val);
        return head;
    }
}