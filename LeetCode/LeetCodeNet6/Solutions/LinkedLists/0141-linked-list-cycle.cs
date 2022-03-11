namespace LeetCodeNet6.Solutions.LinkedLists;

/*
Link:
    https://leetcode.com/problems/linked-list-cycle/
*/
public class Solution141
{
    public bool HasCycle(ListNode? head)
    {
        ListNode? p1 = head, p2 = head?.next;

        while (p2 is not null)
        {
            p1 = p1?.next;
            p2 = p2.next?.next;

            if (p1 == p2) return true;
        }

        return false;
    }
}