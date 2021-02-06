package leetcode.Q002_AddTwoNumbers;

class ListNode {
    int val;
    ListNode next;
    ListNode() {}
    ListNode(int val) { this.val = val; }
    ListNode(int val, ListNode next) { this.val = val; this.next = next; }
}

class Solution {
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        int carry = 0;
        ListNode n1 = l1, n2 = l2;
        ListNode root = new ListNode(), current = root;
        while (n1 != null || n2 != null) {
            int d1 = (n1 == null) ? 0 : n1.val;
            int d2 = (n2 == null) ? 0 : n2.val;
            int sum = d1 + d2 + carry; 
            carry = sum / 10; 
            current.next = new ListNode(sum % 10);
            current = current.next;
            
            if(n1 != null) n1 = n1.next;
            if(n2 != null) n2 = n2.next;
        }
        if(carry != 0) current.next = new ListNode(carry);
        return root.next;
    }
}