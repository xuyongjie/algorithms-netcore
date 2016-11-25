using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode5
    {
        //O(N^2)
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            int length = s.Length;
            int maxStart = 0, maxLength = 1;
            bool[,] p = new bool[length, length];
            for (int i = 0; i < length; i++)
            {
                for (int j = i; j < length; j++)
                {
                    if (i == j)
                    {
                        p[i, j] = true;
                    }
                    else if (i == j - 1 && s[i] == s[j])
                    {
                        p[i, j] = true;
                        maxStart = i;
                        maxLength = 2;
                    }
                    else
                    {
                        p[i, j] = false;
                    }
                }
            }

            for (int i = 3; i <= length; i++)
            {
                for (int j = 0; j <= length - i; j++)
                {
                    if (p[j + 1, j + i - 2] && s[j] == s[j + i - 1])
                    {
                        p[j, j + i - 1] = true;
                        maxStart = j;
                        maxLength = i;
                    }
                    else
                    {
                        p[j, j + i - 1] = false;
                    }
                }
            }

            return s.Substring(maxStart, maxLength);
        }




        //O(N)
        public string LongestPalindrome2(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            string afterHandle = HandleText(s, '#');
            int length = afterHandle.Length;
            int[] rad = new int[length];
            int center = -1;
            int right = -1;
            for (int i = 0; i < length; i++)
            {
                int r = 1;
                if (i <= right)
                {
                    r = Math.Min(rad[2 * center - i], rad[center] - i + center);

                }
                while (i-r>=0&&i+r<length&&afterHandle[i-r] == afterHandle[i+r])
                {
                    r++;
                }
                rad[i] = r;
                if(i+r-1>right)
                {
                    right = i + r-1;
                    center = i;
                }
            }
            int maxIndex = 0, maxRad = 1;
            for(int i=0;i<length;i++)
            {
                if(rad[i]>maxRad)
                {
                    maxRad = rad[i];
                    maxIndex = i;
                }
            }
            int resultMaxLength = maxRad - 1;
            int resultStartIndex = (maxIndex - maxRad + 1) / 2;
            return s.Substring(resultStartIndex, resultMaxLength);
        }

        /// <summary>
        /// 在字符串s中插入字符c
        /// </summary>
        /// <param name="s"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        private string HandleText(string s, char c)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                builder.Append('#').Append(s[i]);
            }
            builder.Append('#');
            return builder.ToString();
        }
    }
}
