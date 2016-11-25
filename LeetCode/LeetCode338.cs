using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode338
    {
        public int[] CountBits(int num)
        {
            int[] p = new int[num+1];
            p[0] = 0;
            if(num==0)
            {
                return p;
            }
            p[1] = 1;
            for(int i=2;i<=num;i++)
            {
                p[i] = p[i >> 1] + p[i % 2];
            }
            return p;
        }
    }
}
