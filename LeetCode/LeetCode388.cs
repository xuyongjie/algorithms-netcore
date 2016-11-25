using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode388
    {
        //核心递推式如下：
        //LF(n)=LD(n-1)+1+fl;
        //LD(n)=LD(n-1)+1+dl;
        //LD、LF数组的索引表示\t的个数，值表示最后一个以n个\t开头的目录或者文件的长度
        public int LengthLongestPath(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            input = input + '\n';
            int[] LD = new int[input.Length / 2];
            int[] LF = new int[input.Length / 2];
            int max = 0;
            int tcount = 0;
            int eachLength = 0;
            bool isFile = false;
            for (int i = 0; i < input.Length; i++)
            {
                char temp = input[i];
                if (temp == '\n')
                {
                    if (isFile)
                    {
                        if (tcount == 0)
                        {
                            LF[tcount] = eachLength;
                        }
                        else
                        {
                            LF[tcount] = LD[tcount - 1] + 1 + eachLength;
                        }
                        max = LF[tcount] > max ? LF[tcount] : max;
                    }
                    else
                    {
                        if (tcount == 0)
                        {
                            LD[tcount] = eachLength;
                        }
                        else
                        {
                            LD[tcount] = LD[tcount - 1] + 1 + eachLength;
                        }
                    }
                    isFile = false;
                    eachLength = 0;
                    tcount = 0;
                }
                else if (temp == '\t')
                {
                    tcount++;
                }
                else if (temp == '.')
                {
                    isFile = true;
                    eachLength++;
                }
                else
                {
                    eachLength++;
                }
            }
            return max;
        }
    }
}
