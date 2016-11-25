using System;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode152
    {
        public int MaxProduct(int[] nums)
        {
            int length = nums.Length;
            int[] MAX = new int[length];//存储以nums[i]为结尾序列的最乘积，MAX[i]=max(max(MAX[i-1]*nums[i],MIN[i-1]*nums[i]),nums[i])
            int[] MIN=new int[length];//存储以nums[i]为结尾序列的最小乘积，MIN[i]=min(min(MIN[i-1]*nums[i],MAX[i-1]*nums),nums[i])
            MAX[0] = nums[0];
            MIN[0]=nums[0];
            int result = MAX[0];
            for (int i = 1; i < length; i++)
            {
                MAX[i] = Math.Max(Math.Max(MAX[i - 1] * nums[i],MIN[i-1]*nums[i]), nums[i]);
                MIN[i] = Math.Min(Math.Min(MAX[i - 1] * nums[i],MIN[i-1]*nums[i]), nums[i]);                
                result = MAX[i] > result ? MAX[i] : result;
            }
            return result;
        }
    }
}