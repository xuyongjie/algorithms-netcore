using System;
using System.Text;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode344
    {
        public string ReverseString(string s)
        {
            StringBuilder builder=new StringBuilder();
            for(int i=s.Length-1;i>=0;i--)
            {
                builder.Append(s[i]);
            }
            return builder.ToString();
        }
    }
}