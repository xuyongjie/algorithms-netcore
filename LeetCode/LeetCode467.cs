using System;
using System.Collections.Generic;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode467
    {
        //s="...zabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcd...."
        //"abaab"
        public int FindSubstringInWraproundString(string p)
        {
            Dictionary<string, bool> m = new Dictionary<string, bool>();
            for (int i = 0; i < p.Length;)
            {
                int j = i;
                string t;

                while (++j < p.Length)
                {
                    if (p[j] == p[j - 1] + 1 || (p[j] == 'a' && p[j - 1] == 'z'))
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    } 
                }
                t = p.Substring(i, j - i);
                if (!m.ContainsKey(t))
                {
                    m.Add(t, true);
                }
                i = j;
            }
            return m.Count;
        }
    }
}