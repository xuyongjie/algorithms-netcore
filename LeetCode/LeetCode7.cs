using System;
namespace Algorithmsnetcore.LeetCode
{
    class LeetCode7
    {
        //考虑溢出
        public int Reverse(int x)
        {
            int p = x;
            long result = 0;
            while (p != 0)
            {
                result = result * 10 + p % 10;
                p = p / 10;
            }
            if (result > int.MaxValue || result < int.MinValue)
            {
                return 0;
            }
            return (int)result;
        }
    }
}