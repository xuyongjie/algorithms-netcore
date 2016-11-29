using System;
using Algorithmsnetcore;
using Algorithmsnetcore.LeetCode;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LeetCode224 lt224=new LeetCode224();
            Console.WriteLine(lt224.Calculate("(1+(4+5+2)-3)+(6+8)"));            
            LeetCode227 lt227=new LeetCode227();
            Console.WriteLine(lt227.Calculate("1+4+5/2-3*6+8"));
            SimpleCalculator cal=new SimpleCalculator();
            Console.WriteLine(cal.Calculate("1+2*(5-2)+8/4-3+2*4+1+2"));
        }
    }
}
