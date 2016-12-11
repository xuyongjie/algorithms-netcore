using System;
namespace Algorithmsnetcore.LeetCode
{
    class LeetCode215
    {
        public int FindKthLargest(int[] nums, int k)
        {
            return DoFind(nums, 0, nums.Length - 1, k);
        }

        //快速排序解决
        private int DoFind(int[] nums, int from, int to, int k)
        {
            if (from == to)
            {
                return nums[from];
            }
            int key = nums[from];
            int dividerIndex = from;
            for (int i = from + 1; i <= to; i++)
            {
                if (nums[i] > key)
                {
                    int temp = nums[dividerIndex];
                    nums[dividerIndex] = nums[i];
                    nums[i] = temp;
                    dividerIndex++;
                }
            }
            int largerCount = dividerIndex - from;
            if (largerCount == 0)
            {
                if (k == 1)
                {
                    return key;
                }
                else
                {
                    return DoFind(nums, dividerIndex + 1, to, k - 1);
                }
            }
            else
            {
                if (largerCount == k - 1)
                {
                    return key;
                }
                else if (largerCount > k - 1)
                {
                    return DoFind(nums, from, dividerIndex - 1, k);
                }
                else
                {
                    return DoFind(nums, dividerIndex, to, k - largerCount);
                }
            }
        }

        void BuildHeap(int[] nums)
        {
            for (int i = nums.Length/2-1; i>=0; i--)
            {
                while(true)
                {
                    int left=nums[i*2+1];
                    int right=nums[i*2+2];
                    
                }
            }
        }
    }
}