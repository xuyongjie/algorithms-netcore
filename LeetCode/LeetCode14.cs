using System;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if(strs==null||strs.Length==0)
            {
                return string.Empty;
            }
            if(strs.Length==1)
            {
                return strs[0];
            }
            string formerResult=strs[0];
            for(int i=1;i<strs.Length;i++)
            {
                formerResult=LongestFromTwo(formerResult,strs[i]);
                if(string.IsNullOrEmpty(formerResult))
                {
                    return string.Empty;
                }
            }
            return formerResult;
        }

        private string LongestFromTwo(string s1, string s2)
        {
            int len = s1.Length < s2.Length ? s1.Length : s2.Length;
            int index = 0;
            for (int i = 0; i < len; i++)
            {
                if (s1[i] != s2[i])
                {
                    break;
                }
                index++;
            }
            return s1.Substring(0, index);
        }
    }
}