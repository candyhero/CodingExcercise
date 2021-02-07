package leetcode.Q234_PalindromeLinkedList;

class ListNode {
    int val;
    ListNode next;
    ListNode() {}
    ListNode(int val) { this.val = val; }
    ListNode(int val, ListNode next) { this.val = val; this.next = next; }
}

class Solution {
    public static void main(String[] args) {
        int[] input = new int[]{ 1, 0, 1 };
        ListNode root = new ListNode();
        ListNode curr = root;
        for (int i = 0; i < input.length; i++) {
            curr.next = new ListNode(input[i]);
            curr = curr.next;
        }
        root = root.next;

        Solution solution = new Solution();
        System.out.println(solution.isPalindrome(root));
    }

    public boolean isPalindrome(ListNode head) {
        if (head == null || head.next == null) return true;

        ListNode mid = head, curr = head.next;
        while (curr != null && curr.next != null) {
            mid = mid.next;
            curr = curr.next.next;
        }
        mid = mid.next;

        ListNode secondHalf = null;
        while (mid != null) {
            curr = mid;
            mid = mid.next;
            curr.next = secondHalf;
            secondHalf = curr;
        }
        
        curr = head;
        while (secondHalf != null) {
            if (curr.val != secondHalf.val) {
                return false;
            }
            curr = curr.next;
            secondHalf = secondHalf.next;
        }
        return true;
    }
}