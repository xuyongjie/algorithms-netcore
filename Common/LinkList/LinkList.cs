using System;
namespace Algorithmsnetcore.LinkList
{
    class LinkNode{
        public int Data{get;set;}
        public LinkNode Next{get;set;}
    }

    class NodeList{
        private LinkNode head;
        public NodeList(LinkNode head)
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