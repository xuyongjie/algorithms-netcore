using System;
namespace Algorithmsnetcore.LinkList
{
    class LinkNode{
        public int Data{get;set;}
        public LinkNode Next{get;set;}
    }

    class LinkList{
        private LinkNode head;
        public LinkList(LinkNode head)
        {
            this.head=head;
        }

        public void Reverse()
        {
            LinkNode p=head;
            if(p==null||p.Next==null)
            {
                return;
            }
            LinkNode q=p.Next;
            LinkNode r=null;
            while(q!=null)
            {
                r=q.Next;
                q.Next=p;
                p=q;
                q=r;
            }
            head.Next=null;
            head=p;
        }

        public void ReverseRecursive()
        {
            if(head==null||head.Next==null)
            {
                return;
            }
            DoReverseRecursive(head);
        }

        private void DoReverseRecursive(LinkNode p)
        {
            if(p.Next==null)
            {
                head.Next=null;
                head=p;
                return;
            }
            LinkNode t=p.Next;
            DoReverseRecursive(t);
            t.Next=p;
        }
        public void Print()
        {
            LinkNode p=head;
            while(p!=null)
            {
                Console.WriteLine(p.Data);
                p=p.Next;
            }
        }
    }
}