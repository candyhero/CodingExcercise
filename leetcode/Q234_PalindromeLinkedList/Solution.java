package leetcode.Q234_PalindromeLinkedList;

class ListNode {
    int val;
    ListNode next;
    ListNode() {}
    ListNode(int val) { this.val = val; }
    ListNode(int val, ListNode next) { this.val = val; this.next = next; }
}

class Solution {
    public boolean isPalindrome(ListNode head) {
        if (head == null || head.next == null) return true;

        // Get the middle point of the list
        // e.g. if there are 3 elements with indice [0..2], mid will be 1, curr will be 3 (null)
        // e.g. if there are 4 elements with indice [0..3], mid will be 1, curr will be 3 (not-null)
        ListNode mid = head, curr = head.next;
        while (curr != null && curr.next != null) {
            mid = mid.next;
            curr = curr.next.next;
        }

        // End of first half / Mid point -> Start of second half
        mid = mid.next;

        // Reverse second half linked list in-place
        ListNode secondHalf = null;
        while (mid != null) {
            curr = mid;
            mid = mid.next;
            curr.next = secondHalf;
            secondHalf = curr;
        }
        
        // Compare first half & second half of the linked list
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
}