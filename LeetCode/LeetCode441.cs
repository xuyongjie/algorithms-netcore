using System;

namespace Algorithmsnetcore.LeetCode
{
    //AC,数学方法
    public class LeetCode441
    {
        // 1+2+3+...+x = n
        // -> (1+x)x/2 = n
        // -> x^2+x = 2n
        // -> x^2+x+1/4 = 2n +1/4
        // -> (x+1/2)^2 = 2n +1/4
        // -> (x+0.5) = sqrt(2n+0.25)
        // -> x = -0.5 + sqrt(2n+0.25)
        public int ArrangeCoins(int n)
        {
            return (int)Math.Floor(-0.5+Math.Sqrt((double)2*n+0.25));
        }
    }
}