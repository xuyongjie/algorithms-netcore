using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode125
    {
        public bool IsPalindrome(string s)
        {
            int length = s.Length;
            if(string.IsNullOrEmpty(s)||length==1)
            {
                return true;
            }
            s = s.ToLower();
            int i = 0, j = length - 1;
            while(i<j)
            {
                if(!IsAlphanumeric(s[i]))
                {
                    i++;
                    continue;
                }
                if (!IsAlphanumeric(s[j]))
                {
                    j--;
                    continue;
                }
                if(s[i]==s[j])
                {
                    i++;
                    j--;
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsAlphanumeric(char c)
        {
            if(c>='a'&&c<='z'||c>='A'&&c<='Z'||c>='0'&&c<='9')
            {
                return true;
            }
            return false;
        }
    }
}
