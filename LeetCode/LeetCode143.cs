namespace Algorithmsnetcore.LeetCode
{
    public class Solution
    {
        public void ReorderList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return;
            }
            ListNode fast = head, slow = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            ListNode head2 = slow.next;
            slow.next = null;
            //Reverse(head2);
            if (head2 != null && head2.next != null)
            {
                ListNode p = head2;
                ListNode q = p.next;
                ListNode r = null;
                while (q != null)
                {
                    r = q.next;
                    q.next = p;
                    p = q;
                    q = r;
                }
                head2.next=null;
                head2=p;
            }
            //Insert head2 to head;
            ListNode leftHalf = head;
            ListNode cur = head2;
            while (leftHalf != null && cur != null)
            {
                ListNode temp = leftHalf.next;
                ListNode temp2 = cur.next;
                leftHalf.next = cur;
                cur.next = temp;
                leftHalf = temp;
                cur = temp2;
            }
        }
    }
}