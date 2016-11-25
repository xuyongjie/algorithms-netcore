using System;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode299
    {
        public string GetHint(string secret, string guess)
        {
            int[] s=new int[10];
            int[] g=new int[10];
            int bull=0;
            int cow=0;
            for(int i=0;i<secret.Length;i++)
            {
                if(secret[i]==guess[i])
                {
                    bull++;
                }
                s[secret[i]-'0']++;
                g[guess[i]-'0']++;
            }
            for(int i=0;i<10;i++)
            {
                cow+=Math.Min(s[i],g[i]);
            }
            cow-=bull;
            return bull+"A"+cow+"B";
        }
    }
}