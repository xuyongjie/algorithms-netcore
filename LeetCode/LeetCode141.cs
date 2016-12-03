
namespace Algorithmsnetcore.LeetCode
{
    /********************
    Given a linked list, determine if it has a cycle in it.
    Follow up:
    Can you solve it without using extra space?
    ******************/
    
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int x) {
     *         val = x;
     *         next = null;
     *     }
     * }
     */

    public class LeetCode141
    {
        public bool HasCycle(ListNode head)
        {
            ListNode slow, fast;
            slow = head;
            fast = head;
            while (slow != null && fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
