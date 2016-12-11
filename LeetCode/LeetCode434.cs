using System;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode434
    {
        public int CountSegments(string s)
        {
            int result=0;
            char formerC=' ';
            for(int i=0;i<s.Length;i++)
            {
                if(formerC==' '&&s[i]!=' ')
                {
                    result++;
                }
                formerC=s[i];
            }
            return result;
        }
    }
}