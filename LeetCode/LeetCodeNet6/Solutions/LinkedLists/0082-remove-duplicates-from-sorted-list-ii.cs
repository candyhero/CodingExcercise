namespace LeetCodeNet6.Solutions.LinkedLists;

/*
Link:
    https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/
*/
public class Solution82
{
    public ListNode? DeleteDuplicates(ListNode? head)
    {
        ListNode? root = head, prev = null, cur = head, lastDeleted = null;

        while (cur is not null)
        {
            if (cur.next is not null && cur.val == cur.next.val) // delete next duplicate
            {
                lastDeleted = cur.next;
                cur.next = cur.next?.next;
            }
            else if (lastDeleted is not null && lastDeleted.val == cur.val) // delete current as the last duplicate
            {
                if (prev is not null) // delete current
                {
                    prev.next = cur.next;
                    cur = prev;
                }
                else // current is root
                {
                    root = cur.next;
                    cur = root;
                }
            }
            else // no duplicate just move
            {
                prev = cur;
                cur = cur.next;
            }
        }

        return root;
    }
}