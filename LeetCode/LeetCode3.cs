using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode3
    {
        public int LengthOfLongestSubstring(string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                return 0;
            }
            int max = 1;
            int former = 1;
            int i, j;
            for(i=1;i<s.Length;i++)
            {
                for(j=i-former;j<i;j++)
                {
                    if(s[i]==s[j])
                    {
                        former = i - j;
                        break;
                    }
                }
                if(j==i)
                {
                    former = former + 1;
                }
                max = former > max ? former : max;
            }
            return max;
        }
    }
}
