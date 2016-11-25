using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode343
    {
        public int IntegerBreak(int n)
        {
            int[] p = new int[n+1];
            p[1] = 1;
            p[2] = 1;
            for(int i=3;i<= n;i++)
            {
                int tempMax = 1;
                for(int j=1;j<=i/2;j++)
                {
                    int temp = Math.Max(p[j] * p[i - j],j*(i-j));
                    temp = Math.Max(temp, p[j] * (i - j));
                    if(temp>tempMax)
                    {
                        tempMax = temp;
                    }
                }
                p[i] = tempMax;
            }
            return p[n];
        }
    }
}
