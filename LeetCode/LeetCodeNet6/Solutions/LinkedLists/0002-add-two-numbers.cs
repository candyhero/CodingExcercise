namespace LeetCodeNet6.Solutions.LinkedLists;

/*
Link:
    https://leetcode.com/problems/add-two-numbers/
*/
public class Solution2
{
    public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        ListNode origin = new(), cur = origin;
        ListNode? p1 = l1, p2 = l2;
        var carry = 0;

        while (p1 is not null || p2 is not null || carry > 0)
        {
            var val = (p1?.val ?? 0) + (p2?.val ?? 0) + carry;
            carry = val / 10;
            
            cur.next = new ListNode(val % 10);
            cur = cur.next;
            
            p1 = p1?.next;
            p2 = p2?.next;
        }

        cur.next = p1 ?? p2;

        return origin.next!;
    }
}