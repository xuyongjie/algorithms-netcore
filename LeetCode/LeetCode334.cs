using System;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode334
    {
        //O(n*n)
        public bool IncreasingTriplet(int[] nums)
        {
            if(nums==null||nums.Length<3)
            {
                return false;
            }
            int[] increaseMax=new int[nums.Length];//存储以nums[i]为结尾的最长自增序列的长度
            increaseMax[0]=1;
            for(int i=1;i<nums.Length;i++)
            {
                increaseMax[i]=1;
                for(int j=0;j<i;j++)
                {
                    if(nums[j]<nums[i])
                    {
                        increaseMax[i]=Math.Max(increaseMax[j]+1,increaseMax[i]);
                    }
                }
                if(increaseMax[i]>=3)
                {
                    return true;
                }
            }
            return false;
        }

        //O(n)
        public bool IncreasingTriplet2(int[] nums)
        {
            int min=int.MaxValue,secondMin=int.MaxValue;
            for(int i=0;i<nums.Length;i++)
            {
                if(nums[i]<=min)
                {
                    min=nums[i];
                }else if(nums[i]<secondMin)
                {
                    secondMin=nums[i];
                }else{
                    return true;
                }
            }
            return false;
        }
    }
}