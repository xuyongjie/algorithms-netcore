using System;

namespace Algorithmsnetcore.LeetCode
{
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int x) { val = x; }
     * }
     */
     //用快慢指针将链表分成左右两份，然后分别排序
     //也就是归并排序
    public class LeetCode148
    {
        public ListNode SortList(ListNode head)
        {
            if(head==null||head.next==null)
            {
                return head;
            }
            ListNode left,right;
            left=head;
            ListNode slowFormer,slow,fast;
            slowFormer=slow=fast=head;
            while(slow!=null&&fast!=null&&fast.next!=null)
            {
                slowFormer=slow;
                slow=slow.next;
                fast=fast.next.next;
            }
            right=slow;
            slowFormer.next=null;
            return Merge(SortList(left),SortList(right));
        }

        private ListNode Merge(ListNode listNode1, ListNode listNode2)
        {
            if(listNode1==null)
            {
                return listNode2;
            }
            if(listNode2==null)
            {
                return listNode1;
            }
            ListNode p=listNode1;
            ListNode q=listNode2;
            ListNode head,r=null;
            if(p.val<q.val)
            {
                head=r=p;
                p=p.next;
            }else{
                head=r=q;
                q=q.next;
            }
            while(true)
            {
                if(p==null)
                {
                    r.next=q;
                    break;
                }
                if(q==null)
                {
                    r.next=p;
                    break;
                }
                if(p.val<q.val)
                {
                    r.next=p;
                    r=r.next;
                    p=p.next;
                    continue;
                }else{
                    r.next=q;
                    r=r.next;
                    q=q.next;
                    continue;
                }
            }
            return head;
        }
    }
}