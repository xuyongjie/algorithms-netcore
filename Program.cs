using System;
using Algorithmsnetcore.LeetCode;
using Algorithmsnetcore.LinkList;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // LeetCode384 lt384=new LeetCode384(new int[]{1,2,3,4,5});
            LeetCode224 lt224=new LeetCode224();
            Console.WriteLine(lt224.Calculate("(1+(4+5+2)-3)+(6+8)"));
        }
    }
}
