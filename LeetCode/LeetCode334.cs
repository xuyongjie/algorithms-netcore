using System;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode334
    {
        public bool IncreasingTriplet(int[] nums)
        {
            if(nums==null||nums.Length<3)
            {
                return false;
            }
            int[] increaseMax=new int[nums.Length];//存储以nums[i]及之前最长自增序列的长度
            increaseMax[0]=1;
            for(int i=1;i<nums.Length;i++)
            {
                increaseMax[i]=1;
                for(int j=i-1;j>=0;j--)
                {
                    if(nums[j]<nums[i])
                    {
                        increaseMax[i]=increaseMax[j]+1;
                        break;
                    }
                }
                if(increaseMax[i]>=3)
                {
                    return true;
                }
            }
            return false;
        }
    }
}