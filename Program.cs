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
            // LeetCode224 lt224=new LeetCode224();
            LeetCode227 lt227=new LeetCode227();
            Console.WriteLine(lt227.Calculate("1+4+5/2-3*6+8"));
        }
    }
}
