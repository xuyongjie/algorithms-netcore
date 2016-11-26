using System;

namespace Algorithmsnetcore.LeetCode
{
    //从两边往中间走，每次移动短的一边
    class LeetCode11
    {
        public int MaxArea(int[] height)
        {
            int len = height.Length;
            int maxResult = int.MinValue;
            int i=0,j=len-1;
            while(true)
            {
                if(i==j)
                {
                    break;
                }
                int square=(j-i)*Math.Min(height[i],height[j]);
                maxResult=square>maxResult?square:maxResult;
                if(height[i]<height[j])
                {
                    i++;
                }else{
                    j--;
                }
            }
            return maxResult;
        }
    }
}