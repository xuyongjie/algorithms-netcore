using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.HDOJ
{
    class HDOJ2602
    {
        public int GetMaxValue(int bagVolume,int[]value,int[] volume)
        {
            int boneCount = value.Length;
            int[,] p = new int[bagVolume + 1, boneCount];
            for(int i=0;i<boneCount;i++)
            {
                p[0, i] = 0;
            }

            for(int i=1;i<=bagVolume;i++)
            {
                for(int j=0;j<boneCount;j++)
                {
                    p[i, j] = Math.Max(p[i>volume[j]?i-volume[j]:0, j>1?j-1:0] + value[j], p[i, j>1?j-1:0]);
                }
            }

            return p[bagVolume, boneCount - 1];
        }
    }
}
