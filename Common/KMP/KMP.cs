using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.KMP
{
    class KMP
    {
        public string Pattern { get; private set; }
        public int[] Next { get; private set; }
        public KMP(string pattern)
        {
            this.Pattern = pattern;
            this.Next = GetNextArray(this.Pattern);
        }

        private int[] GetNextArray(string pattern)
        {
            int length = pattern.Length;
            int[] next = new int[length+1];
            int k = 0;
            next[1] = 0;
            for(int i=2;i<=length;i++)
            {
                while(k>0&&pattern[k]!=pattern[i-1])
                {
                    k = next[k];
                }
                if(pattern[k]==pattern[i-1])
                {
                    k = k + 1;
                }
                next[i] = k;
            }
            return next;
        }

        public List<int> GetAllMatchesIndex(string text)
        {
            List<int> resultIndexs = new List<int>();
            int n = text.Length;
            int m = this.Pattern.Length;
            int q = 0;
            for(int i=0;i<n;i++)
            {
                while(q>0&&Pattern[q]!=text[i])
                {
                    q = Next[q];
                }
                if(Pattern[q]==text[i])
                {
                    q = q + 1;
                }
                if(q==m)
                {
                    resultIndexs.Add(i-m+1);
                    q = Next[q];
                }
            }
            return resultIndexs;
        }

    }
}
