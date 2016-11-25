using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{

    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class LeetCode2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode p = l1;
            ListNode q = l2;
            ListNode r = new ListNode(-1);
            r.next = null;
            ListNode result = r;
            int carry = 0, mod = 0;
            while (p != null && q != null)
            {
                mod = (p.val + q.val + carry) % 10;
                carry = (p.val + q.val + carry) / 10;
                r.next = new ListNode(mod);
                r = r.next;
                p = p.next;
                q = q.next;
            }
            if (p == null)
            {
                while (q != null)
                {
                    mod = (q.val + carry) % 10;
                    carry = (q.val + carry) / 10;
                    r.next = new ListNode(mod);
                    r = r.next;
                    q = q.next;
                }
                if (carry != 0)
                {
                    r.next = new ListNode(carry);
                    r = r.next;
                    r.next = null;
                }
            }
            else
            {
                while (p != null)
                {
                    mod = (p.val + carry) % 10;
                    carry = (p.val + carry) / 10;
                    r.next = new ListNode(mod);
                    r = r.next;
                    p = p.next;
                }
                if (carry != 0)
                {
                    r.next = new ListNode(carry);
                    r = r.next;
                    r.next = null;
                }
            }
            return result.next;
        }
    }
}
