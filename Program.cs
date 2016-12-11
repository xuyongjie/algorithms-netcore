using System;
using Algorithmsnetcore.LeetCode;
using Algorithmsnetcore.LinkList;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LeetCode467 lt467=new LeetCode467();
            Console.WriteLine(lt467.FindSubstringInWraproundString("zab"));
            // LinkNode head=new LinkNode();
            // LinkNode p=head;
            // p.Data=0;
            // for(int i=1;i<=10;i++)
            // {
            //     LinkNode node=new LinkNode();
            //     node.Data=i;
            //     p.Next=node;
            //     p=p.Next;
            // }
            // p.Next=null;
            // LinkList linkList=new LinkList(head);
            // Console.WriteLine("original");
            // linkList.Print();

            // Console.WriteLine("reversed , not recursive");
            // linkList.Reverse();
            // linkList.Print();

            // Console.WriteLine("reversed,recursive");
            // linkList.ReverseRecursive();
            // linkList.Print();

            // Console.WriteLine("reversed again, not recursive");
            // linkList.Reverse();
            // linkList.Print();
            // LeetCode224 lt224=new LeetCode224();
            // Console.WriteLine(lt224.Calculate("(1+(4+5+2)-3)+(6+8)"));            
            // LeetCode227 lt227=new LeetCode227();
            // Console.WriteLine(lt227.Calculate("1+4+5/2-3*6+8"));
            // SimpleCalculator cal=new SimpleCalculator();
            // Console.WriteLine(cal.Calculate("1+2*(5-2)+8/4-3+2*4+1+2"));
            // LeetCode402 lt402=new LeetCode402();
            // Console.WriteLine(lt402.RemoveKdigits("1432219",3));
        }
    }
}
