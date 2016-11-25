using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode6
    {
        public string Convert(string s, int numRows)
        {
            if(string.IsNullOrEmpty(s)||numRows==1)
            {
                return s;
            }
            char[,] array = new char[numRows, s.Length];
            for(int i=0;i<numRows;i++)
            {
                for(int j=0;j<s.Length;j++)
                {
                    array[i, j] = '\0';
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                int r = i % (2 * (numRows - 1));
                r = r < numRows ? r : (2 * (numRows - 1) - r);
                int c = i % (2 * (numRows - 1));
                c = c < numRows ? i / (2 * (numRows - 1)) * (numRows - 1) : (i / (2 * (numRows - 1)) * (numRows - 1) + c-numRows + 1);
                array[r, c] = s[i];
            }
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if(array[i, j] != '\0')
                    {
                        builder.Append(array[i, j]);
                    }
                }
            }
            return builder.ToString();
        }
    }
}
