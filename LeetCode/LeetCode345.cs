using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode345
    {
        public string ReverseVowels(string s)
        {
            int start = 0, end = s.Length - 1;
            char[] array = s.ToArray();
            while(start<=end)
            {
                if(!IsVowel(s[start]))
                {
                    start++;
                    continue;
                }
                if(!IsVowel(s[end]))
                {
                    end--;
                    continue;
                }
                char temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
            return new string(array);
        }

        private bool IsVowel(char c)
        {
            c = char.ToLower(c);
            return c == 'a' || c == 'o' || c == 'e' || c == 'i' || c == 'u';
        }
    }
}
